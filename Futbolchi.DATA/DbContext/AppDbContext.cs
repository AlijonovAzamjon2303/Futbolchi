using Futbolchi2.DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace Futbolchi2.DATA.DbContext2
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Player> players { get; set; }  
    }
}
