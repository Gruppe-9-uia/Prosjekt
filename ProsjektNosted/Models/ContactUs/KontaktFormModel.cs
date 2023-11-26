using System.ComponentModel.DataAnnotations;

namespace Prosjekt.Models
{
    public class KontaktFormModel
    {
        //TODO endre navnene til engelsk
        [Required]
        public string navn { get; set; }
        [Required]
        public string telefon { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string land {  get; set; }
        [Required]
        public string melding { get; set; }
    }
}
