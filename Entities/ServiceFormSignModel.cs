namespace Prosjekt.Entities
{
    public class ServiceFormSignModel
    {
        public int CustomerID_int { get; set; }
        public string EmployeeID_int { get; set; }
        public int FormID_int { get; set; }
        public DateOnly Sign_Date { get; set; }

        public CustomerModel Customer { get; set; }
        public EmployeeUser Employee { get; set; }
        public ServiceFormModel ServiceForm { get; set; }
    
    }
}
