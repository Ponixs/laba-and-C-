using System.ComponentModel.DataAnnotations;


namespace WebAspT.Models
{
    public class ReportLabWork
    {
        [Key]
        public int? id_ReportLW { get; set; }
        public string titleReportLW { get; set; }
        public string dateReportLW { get; set; }
        public string versionReportLW { get; set; }
        public int id_Project { get; set; }
        public int id_Student { get; set; }

    }
}

