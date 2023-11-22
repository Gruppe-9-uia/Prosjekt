namespace Prosjekt.Entities
{
    public class ProductModel
    {
        [StringLength(100)]
        public string SerialNr_str {  get; set; }
        [StringLength(50)]
        public string ProductName_str { get; set; }
        public int Model_Year {  get; set; }
        [StringLength(50)]
        public string Product_Type_str { get; set;}

        public CustomerProductModel CustomerProduct { get; set; }
        public ChecklistModel Checklist { get; set; }
    }
}
