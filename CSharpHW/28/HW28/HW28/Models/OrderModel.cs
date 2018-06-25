using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW28.Models
{
    public class OrderModel
    {
        public string ProductName  { get; set; }
        public double TotalPrice { get; set; }

        public OrderModel(string ProductName, double TotalPrice)
        {
            this.ProductName = ProductName;
            this.TotalPrice = TotalPrice;
        }
    }
}