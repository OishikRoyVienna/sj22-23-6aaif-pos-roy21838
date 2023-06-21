using System;
using System.ComponentModel.DataAnnotations;

namespace SPG_Fachtheorie.Aufgabe3.RazorPages.Dto
{
    public class NewAdvertisementDto
    {
        [Required(ErrorMessage = "Der ProductName ist erforderlich.")]
        [MinLength(3, ErrorMessage = "Der ProductName muss mindestens 3 Zeichen lang sein.")]
        public string? ProductName { get; set; }

        [Required(ErrorMessage = "Das Feld Production ist erforderlich.")]
        [Display(Name = "Production Date")]
        public DateTime Production { get; set; }

        [Required(ErrorMessage = "Das Feld Length ist erforderlich.")]
        [Range(1, int.MaxValue, ErrorMessage = "Die Länge muss größer als 0 sein.")]
        public int Length { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Die Mindestspielzeit muss größer als 0 sein.")]
        public int? MinPlayTime { get; set; }

        [Required(ErrorMessage = "Das Feld CostsPerPlay ist erforderlich.")]
        [Range(0, double.MaxValue, ErrorMessage = "Die Kosten pro Abspielung müssen größer oder gleich 0 sein.")]
        public decimal CostsPerPlay { get; set; }

        [Required(ErrorMessage = "Der Kunde muss ausgewählt werden.")]
        public int CustomerId { get; set; }

        public string? ItemType { get; set; }
    }
}
