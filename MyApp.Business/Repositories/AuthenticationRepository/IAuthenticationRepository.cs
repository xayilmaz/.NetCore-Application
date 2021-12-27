using System.Threading.Tasks;
using MyApp.Business.Requests;
using MyApp.Business.Responses;

namespace MyApp.Business.Repositories.AuthenticationRepository
{
    public interface IAuthenticationRepository
    {
        Task<LoginResponse> Login(LoginRequest loginRequest);
    }
}