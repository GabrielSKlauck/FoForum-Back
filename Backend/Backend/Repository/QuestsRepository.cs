using Backend.Contracts.Repository;
using Backend.DTO;
using Backend.Entity;
using Backend.Infrastructure;
using Dapper;

namespace Backend.Repository
{
    public class QuestsRepository : Connection, IQuestsRepository
    {
        public async Task AddQuest(QuestsDTO quest)
        {
            string sql = @$"INSERT INTO Quests(Title, Description, Posted, UserId)
                            VALUES(@Title, @Description, @Posted, @Userid)";
            await Execute(sql, quest);
        }

        public async Task DeleteQuest(int id, int userId)
        {
            string sql = @$"DELETE FROM QUESTS WHERE ID = @id AND UserId = @userId";
            await Execute(sql, new {id, userId});
        }

        public async Task<IEnumerable<QuestsEntity>> GetMostRecentQuests()
        {
            string sql = "SELECT * FROM QUESTS LIMIT 10";
            return await GetConnection().QueryAsync<QuestsEntity>(sql);
        }

        public async Task<QuestsEntity> GetQuest(int id)
        {
            string sql = @$"SELECT * FROM QUESTS WHERE ID = @Id";
            return await GetConnection().QueryFirstAsync<QuestsEntity>(sql, new { id });
        }

        public async Task<IEnumerable<QuestsEntity>> GetQuestsByIdUser(int id)
        {
            string sql = @$"SELECT * FROM QUESTS WHERE UserId = @id";
            return await GetConnection().QueryAsync<QuestsEntity>(sql, new { id });
        }

        public async Task UpdateQuest(QuestsEntity quest)
        {
            string sql = @$"UPDATE QUESTS SET Title = @Title,
                                                Description = @Description,
                                                Posted = @Posted,
                                                UserId = @UserId
                                                WHERE Id = @Id";
            await Execute(sql, quest);
        }
    }
}
