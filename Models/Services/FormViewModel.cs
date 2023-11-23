namespace Prosjekt.Models.Services
{
    public class FormViewModel
    {
        //parts
        public int OrderNr { get; set; }
        public int UsedPartID { get; set; }
        public string UsedPartName_str { get; set; }
        public int UsedQuantity_available_int { get; set; }
        public int ReplacPartID { get; set; }
        public string ReplacePartName_str { get; set; }
        public int ReplaceQuantity_available_int { get; set; }

        public int FormID_int { get; set; }
        [StringLength(255)]
        public string Repairdescription_str { get; set; }
        public DateOnly ServiceCompleted_date { get; set; }
        public DateOnly AgreedDelivery_date { get; set; }
        public DateOnly ProductRecived_date { get; set; }
        public int BookedServiceWeek_int { get; set; }
        [StringLength(50)]
        public string ShippingMethod_str { get; set; }

        public int Working_Hours_int { get; set; }
        public string signRep {  get; set; }
        public string signKunde {  get; set; }
        public DateOnly signDato { get; set; }
    }
}
