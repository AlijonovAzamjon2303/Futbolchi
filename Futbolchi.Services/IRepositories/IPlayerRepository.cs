using Futbolchi2.DATA.Models;

namespace Futbolchi.Services.IRepositories
{
    public interface IPlayerRepository
    {
        public Task AddPlayerAsync(Player player);

        public Task RemovePlayerAsync(int id);

        public Task UpdatePlayerAsync(int id, Player player);

        public Task<IList<Player>> GetAllAsync();
    }

   
}
