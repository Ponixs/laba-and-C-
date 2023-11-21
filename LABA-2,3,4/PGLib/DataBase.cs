using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace AirLoggerPGLib
{
    public class DataBase : DbContext
    {


        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<UserException> UserException { get; set; } = null!;

        public DataBase(DbContextOptions<DataBase> options) 
            :base(options)
        {
            Database.EnsureCreated();
        }

        public void AddLogInDB(string m, string t, string d, string i)
        {
                UserException Exception1 = new UserException {Message = m, TargetSite = t, dateTimeExc = d, indexForm = i };

                UserException.Add(Exception1);
                SaveChanges();
            
        }



    }
}
