using Backend.DTO;
using Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Contracts.Repository
{
    public interface IQuestsRepository
    {
        Task AddQuest(QuestsDTO quest);

        Task UpdateQuest(QuestsEntity quest);

        Task DeleteQuest(int id, int userId);

        Task<QuestsEntity> GetQuest(int id);

        Task<IEnumerable<QuestsEntity>> GetQuestsByIdUser(int id);

        Task<IEnumerable<QuestsEntity>> GetMostRecentQuests();
    }
}
