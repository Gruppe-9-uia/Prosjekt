using System.ComponentModel.DataAnnotations;

namespace Prosjekt.Models.ServiceOrdre
{
    public class ServiceOrdreModell
    {
        [Required]
        public int customerID { get; set; }
        [Required]
        public int produkttype { get; set; }
        [Required]
        public int årsmodell { get; set; }
        [Required]
        public int mottattDato { get; set; }
        [Required]
        public string serienummer { get; set; }
        [Required]
        public string fulltNavn { get; set; }
        [Required]
        public string adresse { get; set; }
        [Required]
        public string sted { get; set; }
        [Required]
        public string postnummer { get; set; }
        [Required]
        public string epost { get; set; }
        [Required]
        public int mobilnummer { get; set; }
        public string garanti { get; set; }
        [Required]
        public string service_rep { get; set; }
        [Required]
        public string avtaleBeskrivelse { get; set; }
    }
}

