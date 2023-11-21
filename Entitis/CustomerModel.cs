namespace Prosjekt.Entities
{
    public class CustomerModel
    {
        public int ID_int { get; set; }
        public string FirstName_str { get; set; }
        public string LastName_str { get; set; }
        public string Phone_str { get; set;}
        public string Email_str { get; set; }
        public string Street_Address_str { get; set;}
        public string Postal_Code_str { get; set;}
        public PostalCode Address { get; set; }

        public ICollection<ServiceFormModel> ServiceForms { get; }
        public ICollection<CustomerProductModel> CustomerProducts { get; }
        public ICollection<ServiceFormSignModel> ServiceFormsSign { get; }
    }
}
