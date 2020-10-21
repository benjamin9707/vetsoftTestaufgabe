using System;
using System.ComponentModel.DataAnnotations;

namespace vetsoftTestaufgabe.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name = "Vorname", Prompt = "Vorname")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "! Ihr Vorname muss eine Zeichenfolge von mindestens 3 bis 50 Zeichen haben.")]
        [RegularExpression(@"^[A-ZäöüÄÖÜß]+[a-zA-ZäöüÄÖÜß]*$")]
        [Required(ErrorMessage = "Geben Sie Ihren Vornamen ein.")]
        public string FirstName { get; set; }

        [Display(Name = "Nachname", Prompt = "Nachname")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "! Ihr Nachname muss eine Zeichenfolge von mindestens 3 bis 50 Zeichen haben.")]
        [RegularExpression(@"^[A-ZäöüÄÖÜß]+[a-zA-ZäöüÄÖÜß]*$")]
        [Required(ErrorMessage = "Geben Sie Ihren Nachnamen ein.")]
        public string LastName { get; set; }

        [Display(Name = "Adresse", Prompt = "Adresse")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "! Ihre Adresse muss eine Zeichenfolge von mindestens 3 bis 50 Zeichen haben.")]
        [Required(ErrorMessage = "Geben Sie Ihre Adresse ein.")]
        public string Adress { get; set; }

        [Display(Name = "PLZ")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "&iquest; Ihre gültige Postleitzahl muss eine Zeichenfolge 5 Zeichen haben.")]
        [Required(ErrorMessage = "Geben Sie Ihre gültige Postleitzahl ein.")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Unkorrekte Postleitzahl")]
        public string Zipcode { get; set; }

        [Display(Name = "Ort", Prompt = "Ort")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ihr Ortsname muss eine Zeichenfolge von mindestens 3 bis 50 Zeichen haben.")]
        [RegularExpression(@"^[A-ZäöüÄÖÜß]+[a-zA-ZäöüÄÖÜß]*$")]
        [Required(ErrorMessage = "Bitte geben Sie Ihren Ortsnamen ein.")]
        public string City { get; set; }
    }
}
