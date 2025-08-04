using Day28Concepts.Model;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Day28Concepts.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(StudentModel studentModel);

        Task<string> LoginAsync(SignInModel signInModel);
    }
}
