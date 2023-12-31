﻿namespace Prosjekt.Entities
{
    public class ServiceFormEmployeeModel
    {
        public int FormID_int { get; set; }
        public string EmployeeID_int { get; set; }
        public int Working_Hours_int { get; set; }
        [StringLength(255)]
        public string Repair_Description_str { get; set; }

        public ServiceFormModel ServiceForm { get; set; }
        public EmployeeUser Employee { get; set; }
    }
}
