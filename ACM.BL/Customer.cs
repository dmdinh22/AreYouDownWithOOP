using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        //default constructor
        public Customer()
                : this(0) // constructor chaining
        {

        }

        //overload constructor
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            // initialize AddressList so it is empty instead of null
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }

        public int CustomerType { get; set; }

        public static int InstanceCount { get; set; }

        private string _lastName;

        // full property w/ backing field
        public string LastName
        {
            get
            {
                //retrieves backing field
                return _lastName;
            }
            set
            {
                // sets backing field to a value
                _lastName = value;
            }
        }

        // auto implemented property
        public string FirstName { get; set; }

        public string Email { get; set; }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;

                // if first name is not empty
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    // if last name is not empty (set as fullName var)
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        } //FullName

        /// <summary>
        /// Makes sure these properties are filled out
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            // check if last name or email member props are null/empty
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;

            return isValid;
        } //Validate

        // override to string method to return data pertinent to class
        public override string ToString()
        {
            return FullName;
        } //ToString

        public string Log()
        {
            var logString = this.CustomerId + ": " +
                            this.FullName + " " +
                            "Email: " + this.Email + " " +
                            "Status: " + this.EntityState.ToString();
            return logString;
        } //Log

    }
}
