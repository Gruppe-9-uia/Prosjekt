

using System.ComponentModel.DataAnnotations;

namespace Prosjekt.Models
{
    public class ArbeidsdokumentModell
    {
        [Required]
        public required string BooketServiceTilUke { get; set; }
        public DateOnly HendelseMotatt { get; set; }
        public int Orderenummer { get; set; }
        public required string Produkttype { get; set; }
        public required string BeskrivelseFraKunde { get; set; }
        public required string Kundeinfo { get; set; }
        public DateOnly AvtaltLevering { get; set; }
        public DateOnly ProduktMotatt { get; set; }
        public DateOnly AvtaltFerdigstillelse { get; set; }
        public DateOnly ServiceFerdig { get; set; }
        public int AntallTimerBrukt { get; set; }
        public Boolean ServiceSkjemaFerdig { get; set; }
    }
}
