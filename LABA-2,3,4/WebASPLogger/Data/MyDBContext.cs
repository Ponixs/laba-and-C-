
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace MyDB.Data
{
    public class MyDBcontext : DbContext
    {
        public MyDBcontext(DbContextOptions<MyDBcontext> options)
            : base(options)
        {

        }

        public DbSet<UserException> UserException { get; set; }

    }
}
