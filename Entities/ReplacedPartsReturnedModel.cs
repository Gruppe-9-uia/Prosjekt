﻿namespace Prosjekt.Entities
{
    public class ReplacedPartsReturnedModel
    {
        [Required]
        [Key]
        [ForeignKey("PartID_int")]
        public int PartID_int { get; set; }
        [Required]
        [Key]
        [ForeignKey("FormID_int")]
        public int FormID_int { get; set; }
        [Required]
        public int Quantity_int { get; set; }
        [Required]
        public ICollection<PartsModel> Parts { get; set; }
        public ICollection<ServiceFormModel> ServiceForms { get; set; }
    }
}