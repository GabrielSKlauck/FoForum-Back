using Backend.DTO;
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

        Task GetUser(int id);

        Task UpdateUser(UserDTO user);

        Task DeleteUser(int id);
    }
}
