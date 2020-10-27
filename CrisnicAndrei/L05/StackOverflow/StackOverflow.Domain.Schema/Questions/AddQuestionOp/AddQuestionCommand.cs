using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StackOverflow.Domain.Schema.Questions.AddQuestionOp
{
    public class AddQuestionCommand
    {
        public AddQuestionCommand ( string title, string body, string tags,string question)
        {
            Title = title;
            Body = body;
            tags_ = tags.AsEnumerable();
            Question = question;

        }

        [Required]
        public string Title { get;set; }
        [Required]
        public string Body { get;set; }
        [Required]
        public IEnumerable<string> tags_ { get; set; }
        [Required]
        public string Question{get;set}
        

        
    }
}
