using Backend.DTO;
using Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Contracts.Repository
{
    public interface IAnswersRepository
    {
        Task AddAnswers(AnswersDTO answer);

        Task UpdateAnswers(string description, int id);

        Task DeleteAnswers(int id);

        Task<IEnumerable<AnswersEntity>> GetAnswersByQuestId(int id);
    }
}
