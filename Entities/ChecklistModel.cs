using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;


namespace Prosjekt.Entities
{
    public class ChecklistModel
    {
        [Required]
        [Key]
        public string DocID_str { get; set; }
        [Required]
        [ForeignKey("SerialNr_str")]
        public string SerialNr_str { get; set; }
        [Required]
        public string Type_str { get; set; }
        [Required]
        public string Procedure_str { get; set; }
        [Required]
        public DateOnly Starting_Date { get; set; }
        [Required]
        public string Prepared_by_str { get; set; }
        [Required]
        public string xx_Bar_str { get; set; }
        [Required]
        public string Traction_force_Kn { get; set; }
        [Required]
        public string comment_str { get; set; }
       
        //Hydraulic 
        [Required]
        public string Hydraulic_block { get; set; }
        [Required]
        public string Oil_tank { get; set; }
        
        [Required]
        public string HOil_gearbox { get; set; }
        [Required]
        public string Ringe_cylinder_and_replace_seals { get; set; }
        //Mechanical model
        
        [Required]
        public string Cluth_Plate { get; set; }
        [Required]
        public string Check_Brakes { get; set; }
        [Required]
        public string Bearing_drum { get; set; }
        [Required]
        public string PTO_and_storage { get; set; }
        [Required]
        public string Chain_tensioners { get; set; }
        
        [Required]
        public string Wire { get; set; }
        [Required]
        public string Pinion_bearing { get; set; }
        [Required]
        public string Wedge_on_sprocket { get; set; }

        //Electro model
        [Required]
        public string Wiring_on_winch { get; set; }
        [Required]
        public string Pg_test_radio { get; set; }
        [Required]
        public string EOil_gearbox { get; set; }
        [Required]
        public string Button_box { get; set; }
        [Required]
        
        [Key]
        [ForeignKey("Product")]
        public ProductModel product { get; set; }

        //Sign
        public ChecklistSignatureModel ChecklistSignature;
    }
}