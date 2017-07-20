using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderDiplayItem
    {
        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public string ProductName { get; set; }
        public decimal? PurchasePrice { get; set; }
    }
}