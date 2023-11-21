namespace Prosjekt.Entities
{
    public class ProductModel
    {
        [Required]
        [Key]
        public string SerialNr_str {  get; set; }
        [Required]
        public string ProductName_str { get; set; }
        [Required]
        //TODO: sjekk om dett går siden det er lagt på sql som type YEAR
        public int Model_Year {  get; set; }
        [Required]
        public string Product_Type_str { get; set;}

        public CustomerProductModel CustomerProduct { get; set; }
        public ChecklistModel Checklist { get; set; }
    }
}
