using Microsoft.EntityFrameworkCore;
using MyApp.Business.Requests.User;
using MyApp.Business.Responses.User;
using MyApp.Data;
using MyApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Business.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<GetUserResponse>> GetUser()
        {
            var users = await _context.Users.ToListAsync();

            List<GetUserResponse> response = new List<GetUserResponse>();

            foreach (var user in users)
            {
                response.Add(new GetUserResponse
                {
                    Id = user.Id,
                    FirsName = user.FirsName,
                    LastName = user.LastName
                });
            }

            return response;
        }
        public async Task<GetUserByIdResponse> GetUserById(int id)
        {
            var user = await _context.Users.Where(d => d.Id == id).SingleOrDefaultAsync();

            GetUserByIdResponse response = new GetUserByIdResponse()
            {
                Id=user.Id,
                FirsName=user.FirsName,
                LastName=user.LastName
            };

            return response;
        }

        public async Task<GetUserByIdWithDepartmentResponse> GetUserByIdWithDepartment(int id)
        {
            try
            {
                var user = await _context.Users
                    .Include(d => d.Deparment)
                    .Include(u => u.Role)
                    .Where(d => d.Id == id).SingleOrDefaultAsync();

                GetUserByIdWithDepartmentResponse response = new GetUserByIdWithDepartmentResponse()
                {
                    Id = user.Id,
                    FirsName = user.FirsName,
                    LastName = user.LastName,
                    Departments = user.Deparment,
                    Role = user.Role

                };
                return response;
            }
            catch (Exception e)
            {
                return null;
            }
        }




        public async Task<bool> DeleteUser(int id)
        {
            var user = await _context.Users.Where(d => d.Id == id).SingleOrDefaultAsync();
            var deleteEntity = _context.Entry(user);
            deleteEntity.State = EntityState.Deleted;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        

        


        public async Task<PostUserResponse> PostUser(PostUserRequest postUserRequest)
        {
            var userMap = new Users()
            {
                FirsName = postUserRequest.FirsName,
                LastName = postUserRequest.LastName,
                Deparment = postUserRequest.Departments

            };
            await _context.Users.AddAsync(userMap);

            try
            {
                await _context.SaveChangesAsync();
                PostUserResponse response = new PostUserResponse()
                {
                    Id = userMap.Id,
                    FirsName = userMap.FirsName,
                    LastName = userMap.LastName,
                    Departments = userMap.Deparment
                };
                return response;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Task<PutUserResponse> PutUser(PutUserRequest putUserRequest, int id)
        {
            throw new NotImplementedException();
        }
    }
}
