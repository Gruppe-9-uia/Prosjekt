using System.ComponentModel.DataAnnotations;

namespace Prosjekt.Models
{
    public class KontaktFormModell
    {
        [Required]
        public string navn { get; set; }
        [Required]
        public string telefon { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string region {  get; set; }
        [Required]
        public string melding { get; set; }
    }
}
