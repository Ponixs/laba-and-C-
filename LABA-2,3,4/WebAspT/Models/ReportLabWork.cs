using System.ComponentModel.DataAnnotations;


namespace WebAspT.Models
{
    public class ReportLabWork
    {
        [Key]
        public int? id_ReportLW { get; set; }
        public string titleReportLW { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy hh:mm:ss}",
        ApplyFormatInEditMode = true)]
        public DateTime dateReportLW { get; set; }
        public string versionReportLW { get; set; }
        public int id_Project { get; set; }
        public int id_Student { get; set; }

    }
}

