using System.Collections.Generic;
using System.Threading.Tasks;
using MyApp.Business.Requests;
using MyApp.Business.Responses;

namespace MyApp.Business.Repositories.DeparmentRepositories
{
    public interface IDeparmentRepository
    {
        Task<List<GetDeparmentResponse>> GetDeparment();
        Task<GetDeparmentByIdWithUserResponse> GetDeparmentByIdWithUser(int id);
        Task<PostDeparmentResponse> PostDepartment(PostDeparmentRequest postDeparmentRequest);

        Task<GetDeparmentByIdResponse> GetDeparmentById(int id);
        Task<PutDeparmentResponse> PutDeparment(PutDeparmentRequest putDeparmentRequest, int id);
        Task<bool> DeleteDeparment(int id);
    }
}