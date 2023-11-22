namespace Prosjekt.Entities
{
    public class ServiceOrderServiceformModel
    {
        public int OrderID_int { get; set; }
        public int FormID_int { get; set; }
        public ServiceOrderModel ServiceOrder { get; set; }
        public ServiceFormModel serviceForm { get; set; }

    }
}
