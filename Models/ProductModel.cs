namespace Prosjekt.Models
{
    public class ProductModel
    {
        public int SerialNr_str {  get; set; }
        public string ProductName_str { get; set; }
        //TODO: sjekk om dett går siden det er lagt på sql som type YEAR
        public DateOnly Model_Year {  get; set; }
        public string Product_Type_str { get; set;}
    }
}
