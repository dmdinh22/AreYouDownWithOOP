using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using ACM.BL;
using System.Collections.Generic;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            // arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                Email = "jwalker@test.com",
                FirstName = "Johnnie",
                LastName = "Walker",
                AddressList = null
            };
            changedItems.Add(customer as ILoggable);

            var product = new Product(2)
            {
                ProductName = "Blue Label",
                ProductDescription = "Premium Blended Whiskey",
                CurrentPrice = 6M
            };
            changedItems.Add(product as ILoggable);

            // act
            LoggingService.WriteToFile(changedItems);

            // assert
            // Nothing here to assert
        }
    }
}
