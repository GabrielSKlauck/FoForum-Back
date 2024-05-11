using Backend.DTO;
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

        Task UpdateAnswers(AnswersDTO answer);

        Task DeleteAnswers(int id);

        Task<IEnumerable<AnswersDTO>> GetAnswersByQuestId(int id);
    }
}
