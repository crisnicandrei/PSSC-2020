using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflow.Domain.Schema.Questions.AddQuestionOp
{
    [AsChoice]
    public static partial class AddQuestionResult
    {
        public interface IAddQuestionResult { }
        public class QuestionSucces : IAddQuestionResult { }
        public class QuestionFailure : IAddQuestionResult { }
    }
}
