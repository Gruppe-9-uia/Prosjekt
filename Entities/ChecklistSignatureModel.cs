namespace Prosjekt.Entities
{
    public class ChecklistSignatureModel
    {
        public string DocID_str { get; set; }
        public string EmployeeID_int { get; set; }
        public DateOnly Sign_Date { get; set; }
        public ChecklistModel Checklist { get; set; }
        public EmployeeUser employee { get; set; }


    }
}
