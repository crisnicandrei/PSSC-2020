using Primitives.IO;
using System;
using System.Collections.Generic;
using System.Text;
using static StackOverflow.Domain.Schema.Questions.AddQuestionOp.AddQuestionResult;
using static PortExt;
using StackOverflow.Domain.Schema.Questions.AddQuestionOp;

namespace StackOverflow.Domain.Core.Contents.Questions
{
    public static class QuestionsDomain
    {
        public static Port<IAddQuestionResult> AddQuestion(string title, string body, string tags) =>
            NewPort<AddQuestionCommand, IAddQuestionResult>(new AddQuestionCommand(title, body, tags));
    }
}
