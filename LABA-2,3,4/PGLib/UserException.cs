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
}
