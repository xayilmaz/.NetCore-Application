using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyApp.Business.Requests.User;
using MyApp.Business.Responses.User;


namespace MyApp.Business.Repositories.UserRepository
{
    public interface IUserRepository
    {
        Task<List<GetUserResponse>> GetUser();
        Task<GetUserByIdResponse> GetUserById(int id);
        Task<PostUserResponse> PostUser(PostUserRequest postUserRequest);
        Task<GetUserByIdWithDepartmentResponse> GetUserByIdWithDepartment(int id);
        Task<PutUserResponse> PutUser(PutUserRequest putUserRequest, int id);
        Task<bool> DeleteUser(int id);
    }
}
