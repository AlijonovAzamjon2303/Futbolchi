using AutoMapper;
using Futbolchi.DTOS;
using Futbolchi.Services.IRepositories;
using Futbolchi2.DATA.Models;

namespace Futbolchi.Services
{
    public class PlayerServices : IPlayerServices
    {
        IPlayerRepository repository;
        IMapper mapper;
        public PlayerServices(IPlayerRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task AddPlayerAsync(PlayerAddDTO playeradddto)
        {
            var res = mapper.Map<Player>(playeradddto);

            await repository.AddPlayerAsync(res);
        }

        public async Task<IList<Player>> GetAllAsync()
        {
            return await repository.GetAllAsync();  
        }

        public async Task RemovePlayerAsync(int id)
        {
            await repository.RemovePlayerAsync(id);
        }

        public async Task UpdatePlayerAsync(int id, PlayerAddDTO playeradddto)
        {
            var res = mapper.Map<Player>(playeradddto);
            res.Id = id;
            await repository.UpdatePlayerAsync(id, res);
        }
    }
}
