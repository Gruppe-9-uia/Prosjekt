namespace Prosjekt.Models
{
    public class CustomerModel
    {
        [Key]
        [Required]
        public int CustomerID_int { get; set; }
        [Required]
        public string FirstName_str { get; set; }
        [Required]
        public string LastName_str { get;}
        [Required]
        public string Phone_str { get; set;}
        [Required]
        public string Email_str { get; set; }
        [Required]
        public string Street_Address_str { get; set;}
        [Required]
        [ForeignKey("Address_code_int")]
        public int Address_code_int { get; set;}
        public AddressModel Address { get; set; }

        public ICollection<ServiceOrderModel> ServiceOrders { get; }
        public ICollection<ServiceFormModel> ServiceForms { get; }
        public ICollection<CustomerProductModel> CustomerProducts { get; }
        public ICollection<ServiceFormSignModel> ServiceFormsSign { get; }
    }
}
