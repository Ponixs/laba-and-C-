using Microsoft.EntityFrameworkCore;
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
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy hh:mm:ss}", 
        ApplyFormatInEditMode = true)]
        public DateTime dateTimeExc { get; set; }

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
    public class AnalisReport
    {
        [Key]
        public int? id_AnReport { get; set; }
        public int? id_Student { get; set; }
        public int? id_Projekt { get; set; }
        public int? id_Task { get; set; }
        public string? titleAnReport { get; set; }
        public string? typeAnReport { get; set; }
        public string? contextAnReport { get; set; }
    }
    public class ArchiveReportLW
    {
        [Key]
        public int? id_AchiveReportLW { get; set; }
        public int? id_ReportLW { get; set; }
        public string? catalogName { get; set; }
        public string? dateToSaveReportLW { get; set; }
    }
    public class Incident
    {
        [Key]
        public int? Id_Incident { get; set; }
        public int? indexForm { get; set; }
        public int? id_Standart { get; set; }
        public string? dateTimeIncident { get; set; }
        public string? ContextIncident { get; set; }
    }
    public class Materials
    {
        [Key]
        public int? id_Material { get; set; }
        public int? id_Task { get; set; }
        public int? id_Professor { get; set; }
        public string? catalogName { get; set; }
    }

    [PrimaryKey(nameof(id_MetaData), nameof(id_Professor), nameof(id_Student), nameof(id_Projekt), nameof(id_Task))]
    public class MetaData
    {
        public int? id_MetaData { get; set; }
        public int? id_Professor { get; set; }
     
        public int? id_Student { get; set; }
        public int? id_Projekt { get; set; }
        public int? id_Task { get; set; }
        public int? id { get; set; }
        public int? id_Incident { get; set; }
        public int? indexReplice { get; set; }
        public string? hasTextLog { get; set; }
    }
    public class ReportLabWork
    {
        [Key]
        public int? id_ReportLW { get; set; }
        public int? id_Student { get; set; }
        public int? id_Projekt { get; set; }
        public string? titleReportLW { get; set; }
        public string? versionReportLW { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy hh:mm:ss}",
        ApplyFormatInEditMode = true)]
        public DateTime dateReportLW { get; set; }
    }
    public class Standart
    {
        [Key]
        public int? id_Standart { get; set; }
        public string? type_Standart { get; set; }
        public string? ownerStandart { get; set; }
        public string? URL_Standart { get; set; }
        public string? dataPublicStandart { get; set; }
    }

    [PrimaryKey(nameof(id_Task), nameof(id_Professor))]
    public class Task   
    {
        [Key]
        public int? id_Task { get; set; }
        [Key]
        public int? id_Professor { get; set; }
        public int? id_AnalisReport { get; set; }
        public int? id_Material { get; set; }

        public string? contextTask { get; set; }
        public string? taskName { get; set; }
        public string? deadline { get; set; }
    }

}
