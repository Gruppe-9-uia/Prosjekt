using System.ComponentModel.DataAnnotations;

namespace Prosjekt.Models.ServiceSkjema
{
    public class ServiceSkjemaModell
    {
        [Required]
        public string reperasjonsbeskrivelse { get; set; }
        [Required]
        public string medgåtteDeler { get; set; }
        [Required]
        public DateOnly ferdigstiltdato { get; set; }
        [Required]
        public DateOnly avtaltLeveringDato { get; set; }
        [Required]
        public int booketServiceUke { get; set; }
        public string utskiftetDelerRetur { get; set; }
        public DateOnly serivceFerdigDato { get; set; }
        public DateOnly produktMotattDato { get; set; }
        public int Arbeidstimer { get; set; }
        [Required]
        public string forsendelsemåte { get; set; }

        //trenger kanskje data for signatur, eventuelt erstatte det -
        // med noe annet som kan etterligne en signatur.
       
    }
}