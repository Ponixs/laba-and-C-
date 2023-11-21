using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLoggerPGLib
{
    public class Student
    {
        [Key]
        public int id_Student { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int id_Group { get; set; }
    }
}
