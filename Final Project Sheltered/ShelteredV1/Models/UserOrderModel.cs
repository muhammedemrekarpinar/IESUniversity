using ShelteredV1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShelteredV1.Models
{
    public class UserOrderModel
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderTime { get; set; }
        public EnumOrderState OrderState { get; set; }
    }
}