
using Microsoft.EntityFrameworkCore;
using WebAspT.Models;

namespace MyDB.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options)
            : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        }

        public DbSet<UserException> UserException { get; set; }
        public DbSet<WebAspT.Models.ReportLabWork> ReportLabWork { get; set; } = default!;
        public DbSet<WebAspT.Models.Students> Students { get; set; } = default!;

    }
}
