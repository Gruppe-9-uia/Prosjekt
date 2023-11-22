namespace Prosjekt.Entities
{
    public class PostalCode
    {
        [StringLength(50)]
        public string Postal_Code_str { get; set; }
        [StringLength(50)]
        public string City_str { get; set; }
        [StringLength(50)]
        public string State_str { get; set;}
        [StringLength(50)]
        public string Country_str { get;set;}

        public ICollection<CustomerModel> customers { get; }
    }
}
