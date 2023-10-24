using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Prosjekt.Models
{
    public class SjekklisteModel
    {
        public string Document_nr_str { get; set; }
        public string Serial_number_str { get; set; }
        public string Department_ID { get; set; }
        public string Type_str { get; set; }
        public string Procedure_str { get; set; }
        public DateOnly Starting_Date { get; set; }
        public string Prepared_by_str { get; set; }
        public string xx_Bar_str { get; set; }
        public string Brake_force { get; set; }
        public string Traction_force_Kn { get; set; }
        public string Test_winch { get; set; }
        public string comment_str {  get; set; }

        //Hydraulic model
        public string hydraulic_cylinder { get; set; }
        public string Hoses { get; set; }
        public string Hydraulic_block { get; set; }
        public string Oil_tank { get; set; }
        public string Oil_gearbox_box { get; set; }
        public string Ringe_cylinder_and_replace_seals { get; set; }
        public string Brake_cylinder_and_replace_seals { get; set; }

        //Electro model
        public string Wiring_on_winch { get; set; }
        public string Test_radio { get; set; }
        public string Button_box { get; set; }

        //Mechanical model
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