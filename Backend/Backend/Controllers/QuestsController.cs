using Backend.Contracts.Repository;
using Backend.DTO;
using Backend.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("Quest")]
    public class QuestsController : ControllerBase
    {
        private readonly IQuestsRepository _questRepository;

        public QuestsController(IQuestsRepository questsRepository)
        {
            _questRepository = questsRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddQuest(QuestsDTO quest)
        {
            await _questRepository.AddQuest(quest);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateQuest(QuestsEntity quest)
        {
            await _questRepository.UpdateQuest(quest);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetQuestById(int id)
        {
            return Ok(await _questRepository.GetQuest(id));
        }

        [HttpGet("getByUserId{id}")]
        public async Task<IActionResult> GetQuestsByUserId(int id)
        {
            return Ok(await _questRepository.GetQuestsByIdUser(id));
        }

        [HttpGet("getMostRecentQuests")]
        public async Task<IActionResult> GetMostRecentQuests()
        {
            return Ok(await _questRepository.GetMostRecentQuests());
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteQuest(int id, int userId)
        {
            await _questRepository.DeleteQuest(id, userId);
            return Ok();
        }
    }
}
