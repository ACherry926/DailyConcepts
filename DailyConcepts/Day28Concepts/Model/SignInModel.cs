using System.ComponentModel.DataAnnotations;

namespace Day28Concepts.Model
{
    public class SignInModel
    {
        [Required, EmailAddress]
        public string Email { get; set; } 

        [Required]
        public string Password { get; set; }  
    }
}
