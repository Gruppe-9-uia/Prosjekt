using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Prosjekt.Entities
{
    public enum checklistStatus
    {
        Ok, 
        Skiftes, 
        Defekt,
        NULL
    }

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
        public checklistStatus Hydraulic_cylinder { get; set; }
        public checklistStatus Hoses { get; set; }
        public checklistStatus Hydraulic_block { get; set; }
        public checklistStatus Oil_tank { get; set; }
        public checklistStatus HOil_gearbox { get; set; }
        public checklistStatus Ringe_cylinder_and_replace_seals { get; set; }
        public checklistStatus Brake_cylinder_and_replace_seals { get; set; }

        //Mechanical model
        public checklistStatus Clutch_Plate { get; set; }
        public checklistStatus Check_Brakes { get; set; }
        public checklistStatus Bearing_drum { get; set; }
        public checklistStatus PTO_and_storage { get; set; }
        public checklistStatus Chain_tensioners { get; set; }
        public checklistStatus Wire { get; set; }
        public checklistStatus Pinion_bearing { get; set; }
        public checklistStatus Wedge_on_sprocket { get; set; }

        //Electro model
        public checklistStatus Wiring_on_winch { get; set; }
        public checklistStatus Test_radio { get; set; }
        public checklistStatus EOil_gearbox { get; set; }


        public ProductModel product { get; set; }

        //Sign
        public ChecklistSignatureModel ChecklistSignature;
    }
}