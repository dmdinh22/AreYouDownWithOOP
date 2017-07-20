using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// retrieve 1 order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // create instance of Customer class
            Order order = new Order(orderId);

            // temp hard coded values to return a customer
            if (orderId == 1)
            {
                order.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        } //Retrieve

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            // Code that retrieves the defined order fields
            var addressRepository = new AddressRepository();

            // Temporary Hard-coded data
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Johnnie";
                orderDisplay.LastName = "Walker";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
                orderDisplay.ShippingAddress = addressRepository.Retrieve(1);
            }

            orderDisplay.orderDisplayItemList = new List<OrderDiplayItem>();

            // Code that retrieves the order items

            // Temporary Hard-coded data
            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDiplayItem()
                {
                    ProductName = "Sunflowers",
                    PurchasePrice = 15.96M,
                    OrderQuantity = 2
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDiplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
            }
            return orderDisplay;
        } //RetrieveOrderDisplay

        /// <summary>
        /// save current order
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            return true;
        } //Save
    }
}
