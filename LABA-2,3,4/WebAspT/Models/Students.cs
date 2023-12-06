using System.ComponentModel.DataAnnotations;


namespace WebAspT.Models
{
    public class Students
    {
        [Key]
        public int? id_Student { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? id_Group { get; set; }

    }
}

