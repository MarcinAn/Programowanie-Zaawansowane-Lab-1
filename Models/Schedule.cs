using System;
using System.ComponentModel.DataAnnotations;


namespace Programowanie_Zaawansowane_Labolatorium_1.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        public string Subject { get; set; }

        public string Lecturer { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StartSubjectDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndSubjectDate { get; set; }

        public string Type { get; set; }
    }
}
