using Microsoft.Build.Framework;

namespace Prosjekt.Models
{
    public class ElectroModel
    {
        [Required]
        public string Document_nr_str { get; set; }
        public string Department_ID { get; set; }
        public string Wiring_on_winch { get; set; }
        public string Test_radio { get; set; }
        public string Button_box { get; set; }
    }
}