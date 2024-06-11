using Backend.Contracts.Repository;
using Backend.DTO;
using Backend.Entity;
using Backend.Infrastructure;
using Dapper;
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

        public async Task DeleteUser(int id)
        {
            string sql = @$"DELETE FROM USER WHERE ID = @id";
            await Execute(sql, new { id });
        }

        public async Task<UserEntity> GetUser(int id)
        {
            string sql = @$"SELECT * FROM USER WHERE ID = @id";
            return await GetConnection().QueryFirstAsync<UserEntity>(sql, new { id });
        }

        public async Task UpdateUser(UserEntity user)
        {
            var Cryptography = new Cryptography(SHA512.Create());
            string senha = Cryptography.CriptografarSenha(user.Password);

            string sql = @$"UPDATE USER SET Nickname = @Nickname,
                                            Email = @Email,
                                            Password = '{senha}'
                                            WHERE ID = @Id";
            await Execute(sql, user);
        }

        public async Task UpdateProfilePicture(UserPictureEntity user)
        {
            string sql = $@"UPDATE USER SET ProfilePicture = @ProfilePicture WHERE ID = @Id";
            await Execute(sql, user);   
        }

        
    }
}
