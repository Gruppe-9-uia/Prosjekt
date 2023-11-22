using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Prosjekt.Entities
{
    public class ChecklistModel
    {
        [StringLength(50)]
        public string DocID_str { get; set; }
        public string SerialNr_str { get; set; }
        [StringLength(50)]
        public string Type_str { get; set; }
        [StringLength(50)]
        public string Procedure_str { get; set; }
        public DateOnly Starting_Date { get; set; }
        [StringLength(50)]
        public string Prepared_by_str { get; set; }
        [StringLength(50)]
        public string xx_Bar_str { get; set; }
        [StringLength(50)]
        public string Brake_force { get; set; }
        [StringLength(50)]
        public string Traction_force_Kn { get; set; }
        [StringLength(50)]
        public string Test_winch { get; set; }
        [StringLength(250)]
        public string comment_str { get; set; }

        //Hydraulic 
        [StringLength(50)]
        public string Hydraulic_cylinder { get; set; }
        [StringLength(50)]
        public string Hoses { get; set; }
        [StringLength(50)]
        public string Hydraulic_block { get; set; }
        [StringLength(50)]
        public string Oil_tank { get; set; }
        [StringLength(50)]
        public string HOil_gearbox { get; set; }
        [StringLength(50)]
        public string Ringe_cylinder_and_replace_seals { get; set; }
        [StringLength(50)]
        public string Brake_cylinder_and_replace_seals { get; set; }

        //Mechanical model
        [StringLength(50)]
        public string Clutch_Plate { get; set; }
        [StringLength(50)]
        public string Check_Brakes { get; set; }
        [StringLength(50)]
        public string Bearing_drum { get; set; }
        [StringLength(50)]
        public string PTO_and_storage { get; set; }
        [StringLength(50)]
        public string Chain_tensioners { get; set; }
        [StringLength(50)]
        public string Wire { get; set; }
        [StringLength(50)]
        public string Pinion_bearing { get; set; }
        [StringLength(50)]
        public string Wedge_on_sprocket { get; set; }

        //Electro model
        [StringLength(50)]
        public string Wiring_on_winch { get; set; }
        [StringLength(50)]
        public string Test_radio { get; set; }
        [StringLength(50)]
        public string EOil_gearbox { get; set; }


        public ProductModel product { get; set; }

        //Sign
        public ChecklistSignatureModel ChecklistSignature;
    }
}