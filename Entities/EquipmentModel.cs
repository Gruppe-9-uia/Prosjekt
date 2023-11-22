namespace Prosjekt.Entities
{
    public class EquipmentModel
    {
        public int Id_int { get; set; }
        public string Name_str { get; set; }
        public Boolean Availability { get; set; }
        public PartsModel Parts { get; set; }
    }
}
