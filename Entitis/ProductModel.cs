namespace Prosjekt.Entities
{
    public class ProductModel
    {
        public string SerialNr_str {  get; set; }
        public string ProductName_str { get; set; }
        public int Model_Year {  get; set; }
        public string Product_Type_str { get; set;}

        public CustomerProductModel CustomerProduct { get; set; }
        public ChecklistModel Checklist { get; set; }
    }
}
