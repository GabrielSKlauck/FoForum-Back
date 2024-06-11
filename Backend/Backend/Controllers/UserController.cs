using Backend.Contracts.Repository;
using Backend.DTO;
using Backend.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(UserDTO user)
        {
            await _userRepository.AddUser(user);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetUserById(int id)
        {
            return Ok(await _userRepository.GetUser(id));
        }

        [HttpPut("UpdatePerfil")]
        public async Task<IActionResult> UpdatePerfil(UserEntity user)
        {
            await _userRepository.UpdateUser(user);
            return Ok();
        }

        [HttpPut("UpdateProfilePicture")]
        public async Task<IActionResult> UpdateProfilePicture(UserPictureEntity user)
        {
            await _userRepository.UpdateProfilePicture(user);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProfile(int id)
        {
            await _userRepository.DeleteUser(id);
            return Ok();
        }
    }
}
