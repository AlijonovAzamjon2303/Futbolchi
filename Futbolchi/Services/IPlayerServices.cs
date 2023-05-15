using Futbolchi.DTOS;
using Futbolchi2.DATA.Models;

namespace Futbolchi.Services
{
    public interface IPlayerServices
    {
        public Task AddPlayerAsync(PlayerAddDTO playeradddto);

        public Task RemovePlayerAsync(int id);

        public Task UpdatePlayerAsync(int id, PlayerAddDTO playeradddto);

        public Task<IList<Player>> GetAllAsync();
    }
}
