using DB;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace DB
{
    public class DataBase : DbContext
    {
        public DbSet<whitelist> whitelist { get; set; } = null!;



        public DataBase()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=whitelist;Username=postgres;Password=3jLm!%2*3dSsih");
        }


    }
}



