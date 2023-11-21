namespace Prosjekt.Entities
{
    public class PostalCode
    {
        public string Postal_Code_str { get; set; }
        public string City_str { get; set; }
        public string State_str { get; set;}
        public string Country_str { get;set;}

        public ICollection<CustomerModel> customers { get; }
    }
}
