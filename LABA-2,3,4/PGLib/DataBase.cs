using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace AirLoggerPGLib
{
    public class DataBase : DbContext
    {


        //public DbSet<Student> Students { get; set; } = null!;
        public DbSet<UserException> UserException { get; set; } = null!;
        public DbSet<Students> Students { get; set; } = null!;
        public DbSet<Professor> Professor { get; set; } = null!;
        public DbSet<Project> Project { get; set; } = null!;
        public DbSet<Task> Task { get; set; } = null!;
        public DbSet<AnalisReport> AnalisReport { get; set; } = null!;
        public DbSet<Standart> Standart { get; set; } = null!;
        public DbSet<ReportLabWork> ReportLabWork { get; set; } = null!;
        public DbSet<MetaData> MetaData { get; set; } = null!;
        public DbSet<Materials> Materials { get; set; } = null!;
        public DbSet<Incident> Incident { get; set; } = null!;
        public DbSet<ArchiveReportLW> ArchiveReportLW { get; set; } = null!;


        public DataBase(DbContextOptions<DataBase> options) 
            :base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            Database.EnsureCreated();
        }

        public void AddLogInDB(string m, string t, string d, string i)
        {
           
            UserException Exception1 = new UserException { Message = m, TargetSite = t, 
                dateTimeExc = DateTime.Now,
                indexForm = i };

                UserException.Add(Exception1);
                SaveChanges();
            
        }



    }
}



