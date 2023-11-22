using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLoggerPGLib
{
    public class UserException
    {
        [Key]
        public int id { get; set; }
        public string? Message { get; set; }
        public string? TargetSite { get; set; }
        public string? indexForm { get; set; }
        public string? dateTimeExc { get; set; }

    }
    public class Students
    {
        [Key]
        public int? id_Student { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? id_Group { get; set; }
    }
    public class Professor
    {
        [Key]
        public int? id_Professor { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? id_Department { get; set; }
    }
    public class Project
    {
        [Key]
        public int? id_Project { get; set; }
        public int? id_Student { get; set; }
        public string? ProjectName { get; set; }
        public string? versionProject { get; set; }
        public string? CatalogName { get; set; }
    }
}
