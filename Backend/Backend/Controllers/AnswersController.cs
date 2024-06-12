using Backend.Contracts.Repository;
using Backend.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("Answers")]
    public class AnswersController : ControllerBase
    {
        private readonly IAnswersRepository _answersRepository;

        public AnswersController(IAnswersRepository answersRepository)
        {
            _answersRepository = answersRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddAnswer(AnswersDTO answer)
        {
            await _answersRepository.AddAnswers(answer);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAnswer(string description, int id)
        {
            await _answersRepository.UpdateAnswers(description, id);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAnswersByQuestId(int id)
        {
            return Ok(await _answersRepository.GetAnswersByQuestId(id));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAnswer(int id)
        {
            await _answersRepository.DeleteAnswers(id);
            return Ok();
        }
    }
}
