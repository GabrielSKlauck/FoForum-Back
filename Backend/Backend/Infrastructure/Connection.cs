using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Infrastructure
{
    public class Connection
    {
        protected string connectionString = "Server=localhost;Database=foforum;User=root;Password=root;";
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        protected async Task<int> Execute(string sql, object obj)
        {
            using (MySqlConnection con = GetConnection())
            {
                return await con.ExecuteAsync(sql, obj);
            }
        }

        protected async Task ExecuteOnly(string sql)
        {
            using (MySqlConnection con = GetConnection())
            {
                await con.ExecuteAsync(sql);
            }
        }
    }
}
