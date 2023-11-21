namespace Prosjekt.Models;

    public class ArbeidsdokumentModelView
    {
        [Required] public string BooketServiceTilUke { get; set; }

        public DateOnly HendelseMotatt { get; set; }

        public int Orderenummer { get; set; }

        [Required] public string Produkttype { get; set; }

        [Required] public string BeskrivelseFraKunde { get; set; }

        [Required] public string Kundeinfo { get; set; }

        public DateOnly AvtaltLevering { get; set; }

        public DateOnly ProduktMotatt { get; set; }

        public DateOnly AvtaltFerdigstillelse { get; set; }

        public DateOnly ServiceFerdig { get; set; }

        public int AntallTimerBrukt { get; set; }

        public bool ServiceSkjemaFerdig { get; set; }
    }
