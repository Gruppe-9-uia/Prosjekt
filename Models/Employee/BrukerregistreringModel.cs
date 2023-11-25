namespace Prosjekt.Models
{
    [Table("Employee")] 
    public class AddEmployeeModel
    {
        [Required]
        [Key]
        public string ID_int { get; set; }
        [Required]
        [ForeignKey("DepartmentID_int")]
        public int DepartmentID_int { get; set; }
        [Required]
        public string FirstName_str { get; set; }
        [Required]
        public string LastName_str { get; set; }
        [Required]
        public string Phone_str { get; set;}
        [Required]
        public string Email_str { get;set; }
        [Required]
        public string Password_str { get; set; }
        [Required]
        public string Address_str { get; set; }
        [Required]
        public string PostalCode_str { get; set; }
        [Required]
        public string City_str { get; set; }
        
        public string FulltNavn { get; set; }


    }
}