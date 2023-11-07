namespace Prosjekt.Models
{
    public class WarrantyModel
    {
        public int WarrantyID_int { get; set; }
        public string WarrantyName_str { get; set; }
        public string WarrantyType_str { get; set; }
        public DateOnly StartDate_date { get; set; }
        public DateOnly ExpDate_date { get; set; }

    }
}
