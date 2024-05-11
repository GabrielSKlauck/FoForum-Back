using Backend.DTO;
using Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Contracts.Repository
{
    public interface IUserRepository
    {
        Task AddUser(UserDTO user);

        Task<UserEntity> GetUser(int id);

        Task UpdateUser(UserDTO user);

        Task DeleteUser(int id);
    }
}
