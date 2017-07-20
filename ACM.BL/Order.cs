using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        //default constructor
        public Order()
        {

        }

        //overload constructor
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }

        //use offset for customer local time
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> orderItems { get; set; }

        /// <summary>
        /// validate order data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            // check if order date member props are null/empty
            if (OrderDate == null) isValid = false;

            return isValid;
        } //Validate

        // override to string method to return data pertinent to class
        public override string ToString()
        {
            return OrderDate.Value.Date + " (" + OrderId + ")";
        } //ToString

        public string Log()
        {
            var logString = this.OrderId + ": " +
                "Date: " + this.OrderDate.Value.Date + " " +
                "Status: " + this.EntityState.ToString();
            return logString;
        } //Log
    }
}
