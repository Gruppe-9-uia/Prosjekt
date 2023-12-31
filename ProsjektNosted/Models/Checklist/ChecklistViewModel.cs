﻿namespace Prosjekt.Models.Checklist
{
    public class ChecklistViewModel
    {
        [StringLength(50)]
        public string DocID_str { get; set; }
        public string SerialNr_str { get; set; }
        [StringLength(50)]
        public string FirstName_str { get; set; }
        public string LastName_str { get; set; }
        public DateOnly signDate {  get; set; }
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
        public string Hydraulic_cylinder { get; set; } = "";
        public string Hoses { get; set; } = "";
        public string Hydraulic_block { get; set; } = "";
        public string Oil_tank { get; set; } = "";
        public string HOil_gearbox { get; set; } = "";
        public string Ringe_cylinder_and_replace_seals { get; set; } = "";
        public string Brake_cylinder_and_replace_seals { get; set; } = "";

        //Mechanical model
        public string Clutch_Plate { get; set; } = "";
        public string Check_Brakes { get; set; } = "";
        public string Bearing_drum { get; set; } = "";
        public string PTO_and_storage { get; set; } = "";
        public string Chain_tensioners { get; set; } = "";
        public string Wire { get; set; } = "";
        public string Pinion_bearing { get; set; } = "";
        public string Wedge_on_sprocket { get; set; } = "";

        //Electro model
        public string Wiring_on_winch { get; set; } = "";
        public string Test_radio { get; set; } = "";
        public string EOil_gearbox { get; set; } = "";
    }
}
