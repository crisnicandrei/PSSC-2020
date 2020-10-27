using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using StackOverflow.Domain.Schema.Questions.AddQuestionOp

namespace StackOverflow.Domain.Schema.Questions.AddQuestionOp
{
    [AsChoice]
    public static partial class AddQuestionResult : ICreateQuestion
    {
        public interface IAddQuestionResult { }
        public class QuestionSucces : IAddQuestionResult { }
        public class QuestionFailure : IAddQuestionResult { }
        public UserCreated user_ { get; private set; }

        [Required]
        public QuestionMO question_ { get; private set; }

        [Required]
        public Guid questionID_ { get; private set; }
        
        [Required]
        public int votes_ { get; private set; }

        [Required]
        public Dictionary<Guid, bool> votesMap_ { get; private set; }

        public QuestionPublished(QuestionMO question, Guid questionID, UserCreated user) {
            question_ = question;
            questionID_ = questionID;
            user_ = user;
            votes_ = 0;
            votesMap_ = new Dictionary<Guid, bool>();
        }

        public void VoteQuestion(UserCreated fromUser, bool vote) {
            if (votesMap_.Contains(new KeyValuePair<Guid, bool>(fromUser.userId_, vote))) {
                return;
            }
            else if (votesMap_.ContainsKey(fromUser.userId_)) {
                if (vote) {
                    votes_ += 2;
                    votesMap_[fromUser.userId_] = true;
                }
                else {
                    votes_ -= 2;
                    votesMap_[fromUser.userId_] = false;
                }
            }
            else {
                if (vote) {
                    votes_ += 1;
                }
                else {
                    votes_ -= 1;
                }
                votesMap_.Add(fromUser.userId_, vote);
            }
        }
    };

    public class QuestionNotPublished : ICreateQuestion {
        [Required]
        public string reason_ { get; private set; }

        public QuestionNotPublished(string reason) {
            reason_ = reason;
        }
    };

    public class QuestionValidationFailed : ICreateQuestion {
        [Required]
        public IEnumerable<string> validationErrors_ { get; private set; }

        public QuestionValidationFailed(IEnumerable<string> validationErrors) {
            validationErrors_ = validationErrors.AsEnumerable();
        }
    };
}

