namespace Prosjekt.Models
{
    public class EmployeeModel
    {
        public int EmployeeID_int { get; set; }
        public string FirstName_str { get; set; }
        public string LastName_str { get; set; }
        public string Phone_str { get; set;}
        public string Email_str { get;set; }
        public string Password_str { get; set; }

        //TODO: kanskje gjør det om til emun
        public string Level_str { get; set; }
        public DepartmentModel Department { get; set; }

    }
}
