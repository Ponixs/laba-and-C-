using System.ComponentModel.DataAnnotations;

namespace WebAspT.Models
{
    public class UserException
    {
        [Key]
        public int id { get; set; }
        public string? Message { get; set; }
        public string? TargetSite { get; set; }
        public string? indexForm { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy hh.mm.ss}", 
        ApplyFormatInEditMode = true)]
        public DateTime dateTimeExc { get; set; }

    }
}
