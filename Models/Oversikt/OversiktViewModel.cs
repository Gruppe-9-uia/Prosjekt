namespace Prosjekt.Models.Oversikt
{
    public class OversiktViewModel
    {
        public Boolean status {  get; set; }
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

        [StringLength(50)]
        public string DocID_str { get; set; }
        public string SerialNr_str { get; set; }
        [StringLength(50)]
        public string FirstName_str { get; set; }
        public string LastName_str { get; set; }
        public DateOnly signDate { get; set; }
        public string Type_str { get; set; }
        [StringLength(50)]
        public string Procedure_str { get; set; }
        public DateOnly Starting_Date { get; set; }
        [StringLength(50)]
        public string Prepared_by_str { get; set; }
        [StringLength(50)]
        public string xx_Bar_str { get; set; }
        [StringLength(50)]
        public string Brake_force { get; set; }
        [StringLength(50)]
        public string Traction_force_Kn { get; set; }
        [StringLength(50)]
        public string Test_winch { get; set; }
        [StringLength(250)]
        public string comment_str { get; set; }

        //Hydraulic 
        public string Hydraulic_cylinder { get; set; } = "";
        public string Hoses { get; set; } = "";
        public string Hydraulic_block { get; set; } = "";
        public string Oil_tank { get; set; } = "";
        public string HOil_gearbox { get; set; } = "";
        public string Ringe_cylinder_and_replace_seals { get; set; } = "";
        public string Brake_cylinder_and_replace_seals { get; set; } = "";

        //Mechanical model
        public string Clutch_Plate { get; set; } = "";
        public string Check_Brakes { get; set; } = "";
        public string Bearing_drum { get; set; } = "";
        public string PTO_and_storage { get; set; } = "";
        public string Chain_tensioners { get; set; } = "";
        public string Wire { get; set; } = "";
        public string Pinion_bearing { get; set; } = "";
        public string Wedge_on_sprocket { get; set; } = "";

        //Electro model
        public string Wiring_on_winch { get; set; } = "";
        public string Test_radio { get; set; } = "";
        public string EOil_gearbox { get; set; } = "";
    }
}
