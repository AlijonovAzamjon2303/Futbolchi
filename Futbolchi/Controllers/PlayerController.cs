using Futbolchi.DTOS;
using Futbolchi.Services;
using Futbolchi.Services.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Futbolchi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        IPlayerServices services;

        public PlayerController(IPlayerServices services)
        {
            this.services = services;
        }

        [HttpPost] 
        public async Task<IActionResult> AddPlayerAsync(PlayerAddDTO playerAddDTO)
        {
            await services.AddPlayerAsync(playerAddDTO);    
            return Ok("Qo'shildi");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPlayerAsync()
        {
            return Ok(await services.GetAllAsync());
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePlayerAsync(int id, PlayerAddDTO playerAddDTO)
        {
            await services.UpdatePlayerAsync(id, playerAddDTO);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePlayerAsync(int id)
        {
            await services.RemovePlayerAsync(id);
            return Ok();
        }
    }
}
