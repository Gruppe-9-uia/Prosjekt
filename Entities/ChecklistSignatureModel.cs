using Prosjekt.Entities;

namespace Prosjekt.Entities
{
    public class ChecklistSignatureModel
    {
        [Key]
        [Required]
        [ForeignKey("DocID_str")]
        public string DocID_str { get; set; }
        [Required]
        [Key]
        [ForeignKey("EmployeeID_int")]
        public int EmployeeID_int { get; set; }
        [Required]
        public DateOnly Sign_Date { get;}
        public ChecklistModel Checklist { get; set; }
        public EmployeeUser employee { get; set; }


    }
}
