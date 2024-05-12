using Backend.Contracts.Repository;
using Backend.DTO;
using Backend.Entity;
using Backend.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Repository
{
    public class UserRepository : Connection, IUserRepository
    {
        
        public  async Task AddUser(UserDTO user)
        {
            var Cryptography = new Cryptography(SHA512.Create());
            string senha = Cryptography.CriptografarSenha(user.Password);

            string sql = @$"INSERT INTO USER(Nickname, Email, Password, ProfilePicture)
                            VALUES(@Nickname, @Email, '{senha}', 'null')";

            await Execute(sql, user);
        }

        public Task DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
