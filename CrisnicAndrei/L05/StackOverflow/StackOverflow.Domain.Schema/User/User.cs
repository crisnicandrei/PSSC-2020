using System.ComponentModel.DataAnnotations;
namespace StackOverflow.Domain.Schema.User
{
    public struct User {
        [Required]
        public string FirstName{ get; set; }
        
        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email {get; set; }

        public User (string firstName, string lastName, string email) {
            FirstName_ = firstName;
            LastName_ = lastName;
            Email = email;
        }
    };
}