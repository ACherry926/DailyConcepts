using Day29Concepts.Model;
using Microsoft.AspNetCore.Identity;

namespace Day29Concepts.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);

        Task<string> LoginAsync(SignInModel signInModel);
    }
}