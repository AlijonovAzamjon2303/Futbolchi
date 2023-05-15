using AutoMapper;
using Futbolchi.Services.IRepositories;
using Futbolchi2.DATA.DbContext2;
using Futbolchi2.DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace Futbolchi.Services.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private AppDbContext db;
        IMapper mapper;
        public PlayerRepository(AppDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public  async Task AddPlayerAsync(Player player)
        {
            await db.players.AddAsync(player); 
            await db.SaveChangesAsync();
        }

        public async Task<IList<Player>> GetAllAsync()
        {
            return await db.players.ToListAsync();
        }

        public async Task RemovePlayerAsync(int id)
        {
            var res = await db.players.FirstOrDefaultAsync(p => p.Id == id);
            if (res != null)
            {
                db.players.Remove(res);
            }
            await db.SaveChangesAsync();
        }

        public async Task UpdatePlayerAsync(int id, Player player)
        {
            var old = await db.players.FirstOrDefaultAsync(x => x.Id == id);
            db.players.Attach(old).CurrentValues.SetValues(player);
            await db.SaveChangesAsync();
        }
    }
}
