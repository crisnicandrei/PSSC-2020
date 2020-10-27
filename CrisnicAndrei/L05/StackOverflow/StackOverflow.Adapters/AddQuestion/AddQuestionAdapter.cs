using Primitives.IO;
using StackOverflow.Domain.Schema.Questions.AddQuestionOp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static StackOverflow.Domain.Schema.Questions.AddQuestionOp.AddQuestionResult;

namespace StackOverflow.Adapters.AddQuestion
{
    public class AddQuestionAdapter : Adapter<AddQuestionCommand, IAddQuestionResult>
    {
        public override Task PostConditions(AddQuestionCommand cmd, IAddQuestionResult result, object state)
        {
            throw new NotImplementedException();
        }

        public override Task<IAddQuestionResult> Work(AddQuestionCommand cmd, object state)
        {
            throw new NotImplementedException();
        }
    }
}
