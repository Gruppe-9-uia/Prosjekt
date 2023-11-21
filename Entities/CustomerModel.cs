namespace Prosjekt.Entities
{
    public class CustomerModel
    {
        [Key]
        [Required]
        public int ID_int { get; set; }
        [Required]
        public string FirstName_str { get; set; }
        [Required]
        public string LastName_str { get; set; }
        [Required]
        public string Phone_str { get; set;}
        [Required]
        public string Email_str { get; set; }
        [Required]
        public string Street_Address_str { get; set;}
        [Required]
        [ForeignKey("Postal_Code_str")]
        public string Postal_Code_str { get; set;}
        public PostalCode Address { get; set; }

        public ICollection<ServiceOrderModel> ServiceOrders { get; }
        public ICollection<ServiceFormModel> ServiceForms { get; }
        public ICollection<CustomerProductModel> CustomerProducts { get; }
        public ICollection<ServiceFormSignModel> ServiceFormsSign { get; }
    }
}
