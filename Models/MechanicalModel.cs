using Microsoft.Build.Framework;

namespace Prosjekt.Models
{
    public class MechanicalModel
    {
        [Required]
        public string Document_nr_str { get; set; }
        public string Department_ID { get; set; } = string.Empty;
        public string Clutch_Plate { get; set; }
        public string Brakes { get; set; }
        public string Bearing_drum { get; set; }
        public string PTO_and_storage { get; set; }
        public string Chain_tensioners { get; set; }
        public string Wire { get; set; }
        public string Pinion_bearing { get; set; }
        public string Wedge_on_sprocket { get; set; }
    }
}