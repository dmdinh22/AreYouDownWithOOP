using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        //default constructor
        public Product()
        {

        }

        //overload constructor
        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        private string _ProductName;

        public string ProductName
        {
            get
            {
                //insert spaces into string when getting
                return _ProductName.InsertSpaces();
            }
            set { _ProductName = value; }
        }

        /// <summary>
        /// validate product data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            // check if product name or price member props are null/empty
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        } //Validate

        // override to string method to return data pertinent to class
        public override string ToString()
        {
            return ProductName;
        } //ToString

        public string Log()
        {
            var logString = this.ProductId + ": " +
                            this.ProductName + " " +
                            "Email: " + this.ProductDescription + " " +
                            "Status: " + this.EntityState.ToString();
            return logString;
        } //Log
    }
}
