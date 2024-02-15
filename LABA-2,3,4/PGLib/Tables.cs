using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class whitelist
    {
        [Key]
        public int id { get; set; }
        public string? connPoint { get; set; }
        public string? UID { get; set; }
    }
}
