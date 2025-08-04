using Microsoft.AspNetCore.Identity;

namespace Day29Concepts.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
