using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Prosjekt.Models
{
    public class SjekklisteModel
    {
        public string Document_nr_str { get; set; }
        public string Serial_number_str { get; set; }
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
        public HydralicModel hydralicModel { get; set; }   = new HydralicModel();

        //Electro model
        public ElectroModel electroModel { get; set; } = new ElectroModel();

        //Mechanical model
        public MechanicalModel mechanicalModel { get; set; } = new MechanicalModel();

        //Sign model
        public SginModel sginModel { get; set; } = new SginModel();
    }
}