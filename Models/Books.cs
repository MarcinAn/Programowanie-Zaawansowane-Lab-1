using System;
using System.ComponentModel.DataAnnotations;


namespace Programowanie_Zaawansowane_Labolatorium_1.Models
{
    public class Books
    {
        public int Id { get; set; }

        [Display(Name ="Numer klienta")]
        [Required(ErrorMessage ="Proszę wprowadzić numer klienta")]
        [StringLength(5,MinimumLength =5,ErrorMessage ="Numer urzytkownika powinien zawierać 5 cyfr.")]
        [RegularExpression(@"[0-9]{5}",ErrorMessage ="Numer klienta powinien składać się z 5 cyfr")]
        public string CustomerID { get; set; }

        [Display(Name = "Tytuł")]
        [Required(ErrorMessage = "Proszę wprowadzić tytuł.")]
        public string Title { get; set; }

        [Display(Name = "Autor")]
        [Required(ErrorMessage = "Proszę wprowadzić autora.")]
        public string Author { get; set; }

        [Display(Name = "Data wypożyczenia")]
        [Required(ErrorMessage = "Proszę wprowadzić datę wypożyczenia.")]
        [DataType(DataType.Date)]
        public DateTime BorrowDate { get; set; }

        [Display(Name = "Data zwrócenia")]
        [Required(ErrorMessage = "Proszę wprowadzić datę zwrotu.")]
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }

        [Display(Name = "Egzemplarze")]
        [Required(ErrorMessage = "Należy wprowadzić ilość egzemplarzy (maksymalnie 5).")]
        [Range(minimum: 1, maximum: 5, ErrorMessage = "Można wypożyczyć maksymalnie 5 egzemplarzy.")]
        public int BooksAmount { get; set; }
    }
}
