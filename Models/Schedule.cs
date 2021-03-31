using System;
using System.ComponentModel.DataAnnotations;


namespace Programowanie_Zaawansowane_Labolatorium_1.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        [Display(Name = "Przedmiot")]
        [Required(ErrorMessage = "Proszę wprowadzić nazwę przedmiotu.")]
        public string Subject { get; set; }

        [Display(Name = "Wykładowca")]
        [Required(ErrorMessage = "Proszę wprowadzić imię i nazwisko.")]
        public string Lecturer { get; set; }

        [Display(Name = "Data rozpoczęścia")]
        [Required(ErrorMessage = "Proszę wprowadzić datę.")]
        [DataType(DataType.DateTime)]
        public DateTime StartSubjectDate { get; set; }

        [Display(Name = "Data zakończenia")]
        [Required(ErrorMessage = "Proszę wprowadzić datę.")]
        [DataType(DataType.DateTime)]
        public DateTime EndSubjectDate { get; set; }

        [Display(Name = "Rodzaj zajęć")]
        [Required(ErrorMessage = "Proszę wprowadzić rodzaj zajęć.")]
        [RegularExpression(@"(Labolatorium)")]
        public string Type { get; set; }
    }
}
