namespace Prosjekt.Models
{
    public class CustomerModel
    {
        public int CustomerID_int { get; set; }
        public string FirstName_str { get; set; }
        public string LastName_str { get;}
        public string Phone_str { get; set;}
        public string Street_Address_str { get; set;}
        public string Street_number_str { get; set;}
        public int Address_code_int { get; set;}
        public AddressModel Address { get; set; }
    }
}
