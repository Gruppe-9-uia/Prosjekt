namespace Prosjekt.Models
{
    [Table("Employee")] 
    public class AddEmployeeModel
    {
        public string ID_int { get; set; }
        public string Department { get; set; }
        public string FirstName_str { get; set; }
        public string LastName_str { get; set; }
        public string Phone_str { get; set;}
        public string Email_str { get;set; }
        public string City_str { get; set; }
        public string FulltNavn { get; set; }


    }
}