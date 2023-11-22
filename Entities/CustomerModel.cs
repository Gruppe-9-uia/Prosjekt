namespace Prosjekt.Entities
{
    public class CustomerModel
    {
        public int ID_int { get; set; }
        [StringLength(50)]
        public string FirstName_str { get; set; }
        [StringLength(50)]
        public string LastName_str { get; set; }
        [StringLength(50)]
        public string Phone_str { get; set;}
        [StringLength(50)]
        public string Email_str { get; set; }
        [StringLength(50)]
        public string Street_Address_str { get; set;}
        [StringLength(50)]
        public string Postal_Code_str { get; set;}
        public PostalCode Address { get; set; }
        public ServiceFormSignModel ServiceFormSign { get; set; }
        public ICollection<CustomerProductModel> CustomerProducts { get; }
    }
}
