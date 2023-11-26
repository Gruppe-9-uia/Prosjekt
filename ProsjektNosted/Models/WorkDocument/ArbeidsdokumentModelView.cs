using System;
using System.ComponentModel.DataAnnotations;

namespace Prosjekt.Models;

    public class ArbeidsdokumentModelView
    {
        public string BooketServiceTilUke { get; set; }

        public DateOnly HendelseMotatt { get; set; }

        public int Orderenummer { get; set; }

        public string Produkttype { get; set; }

        public string BeskrivelseFraKunde { get; set; }

        public string Kundeinfo { get; set; }

        public DateOnly AvtaltLevering { get; set; }

        public DateOnly ProduktMotatt { get; set; }

        public DateOnly AvtaltFerdigstillelse { get; set; }

        public DateOnly ServiceFerdig { get; set; }

        public int AntallTimerBrukt { get; set; }

        public bool ServiceSkjemaFerdig { get; set; }
    }
