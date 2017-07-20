using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// retrieve 1 product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // create instance of product class
            Product product = new Product(productId);

            Object myObject = new object();
            Console.WriteLine("Object: " + myObject.ToString());
            Console.WriteLine("Product: " + product.ToString());

            // temp hard coded values to return a product
            if (productId == 2)
            {
                product.ProductName = "Jordan 1";
                product.ProductDescription = "Air Jordans";
                product.CurrentPrice = 500.0M;
            }
            return product;
        } //Retrieve

        /// <summary>
        /// save current product
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {
                    // Call Insert Stored Proc
                }
                else
                {
                    // Call Update Stored Proc
                }
            }
            return success;
        } //Save
    }
}
