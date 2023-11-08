namespace Prosjekt.Models
{
    public class AddressModel
    {
        [Required]
        [Key]
        public int Address_code_int { get; set; }
        [Required]
        public string PostalCode_str { get; set; }
        [Required]
        public string City_str { get; set; }
        [Required]
        public string State_str { get; set;}
        [Required]
        public string Country_str { get;set;}

        public ICollection<CustomerModel> customers { get; }
    }
}
