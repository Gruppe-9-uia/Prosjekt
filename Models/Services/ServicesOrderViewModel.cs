namespace Prosjekt.Models.Services
{
    public class ServicesOrderViewModel
    {
        //Services order
        public int OrderID_int { get; set; }
        public int CustomerID_int { get; set; }
        public string Order_type_str { get; set; }
        public DateOnly Received_Date { get; set; }
        public string Description_From_Customer_str { get; set; }

        //customer
        public int CustumerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        //Warranty
        public int WarrantyID { get; set; }
        public string WarrantyName { get; set; }

        //Product
        public string SerialNr { get; set; }
        public string ProductName_str { get; set; }
        public int Model_Year { get; set; }
        public string Product_Type_str { get; set; }

    }
}
