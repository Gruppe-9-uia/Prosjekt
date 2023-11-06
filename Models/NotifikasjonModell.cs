using System.ComponentModel.DataAnnotations;

namespace Prosjekt.Models
{
    public class Notifikasjon
    {
        public int Id { get; set; }
        public string Melding { get; set; }
        public string Status { get; set; }
        public string Avdeling { get; set; }
        public DateTime DatoTid { get; set; } = DateTime.Now;
        public bool IsBookmarked { get; set; }
    }

}



