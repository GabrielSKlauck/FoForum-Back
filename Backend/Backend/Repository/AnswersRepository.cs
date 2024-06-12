using Backend.Contracts.Repository;
using Backend.DTO;
using Backend.Entity;
using Backend.Infrastructure;
using Dapper;

namespace Backend.Repository
{
    public class AnswersRepository : Connection, IAnswersRepository
    {
        public async Task AddAnswers(AnswersDTO answer)
        {
            string sql = @"INSERT INTO ANSWERS(DESCRIPTION, POSTED, USERID, QUESTID)
                            VALUES(@Description, @Posted, @UserId, @QuestId)";
            await Execute(sql, answer);
        }

        public async Task DeleteAnswers(int id)
        {
            string sql = @"DELETE FROM ANSWERS WHERE ID = @id";
            await Execute(sql, new { id });
        }

        public async  Task<IEnumerable<AnswersEntity>> GetAnswersByQuestId(int id)
        {
            string sql = @"SELECT * FROM ANSWERS WHERE ID = @id";
            return await GetConnection().QueryAsync<AnswersEntity>(sql, new {id});
        }

        public async Task UpdateAnswers(string description, int id)
        {
            string sql = @"UPDATE ANSWERS SET Description = @Description
                                                WHERE ID = @id";
            await Execute(sql, new {description, id});
        }
    }
}
