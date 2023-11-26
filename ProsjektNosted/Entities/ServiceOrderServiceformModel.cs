namespace Prosjekt.Entities
{
    public class ServiceOrderServiceformModel
    {
        public int OrderID_int { get; set; }
        public int FormID_int { get; set; }
        public string DocID_str { get; set; }
        public ServiceOrderModel ServiceOrder { get; set; }
        public ServiceFormModel serviceForm { get; set; }

        public ChecklistModel checklist { get; set; }

    }
}
