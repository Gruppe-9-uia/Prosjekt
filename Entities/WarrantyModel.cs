﻿namespace Prosjekt.Entities
{
    public class WarrantyModel
    {
        public int ID_int { get; set; }
        [StringLength(20)]
        public string WarrantyName_str { get; set; }
        public CustomerProductModel CustomerProduct { get; set; }

    }
}
