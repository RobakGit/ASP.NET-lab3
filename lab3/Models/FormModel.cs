using System.ComponentModel.DataAnnotations;

namespace lab3.Models
{
    public class FormModel
    {
        [Display(Name = "Imię")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Ilość powtórzeń")]
        [Range(1,5)]
        public int Repetition { get; set; }
    }
}