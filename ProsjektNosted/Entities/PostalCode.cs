namespace Prosjekt.Entities
{
    public class PostalCode
    {
        //henter og setter verdi til en egenskap
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
