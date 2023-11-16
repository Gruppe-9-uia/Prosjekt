namespace Prosjekt.Entities
{
    public class PostalCode
    {
        [Required]
        [Key]
        public string Postal_Code_str { get; set; }
        [Required]
        public string City_str { get; set; }
        [Required]
        public string State_str { get; set;}
        [Required]
        public string Country_str { get;set;}

        public ICollection<CustomerModel> customers { get; }
    }
}
