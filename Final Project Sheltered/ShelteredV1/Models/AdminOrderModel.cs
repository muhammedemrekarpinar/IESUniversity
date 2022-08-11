using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShelteredV1.Entity;

namespace ShelteredV1.Models
{
    public class AdminOrderModel
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderTime { get; set; }
        public EnumOrderState OrderState { get; set; }
        public int Count { get; set; }
    }
}