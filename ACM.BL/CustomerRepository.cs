using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        /// <summary>
        /// Retrieve 1 customer.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // create instance of Customer class
            Customer customer = new Customer(customerId);

            // grab list of addresses for this customer
            customer.AddressList = addressRepository
                .RetrieveByCustomerId(customerId).ToList();

            // temp hard coded values to return a customer
            if (customerId == 1)
            {
                customer.Email = "jwalker@test.com";
                customer.FirstName = "Johnnie";
                customer.LastName = "Walker";
            }
            return customer;
        } //Retrieve

        /// <summary>
        /// Retrieve all
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            //CODE
            return new List<Customer>();
        } //Retrieve

        /// <summary>
        ///  Saves current customer.
        /// </summary>
        public bool Save(Customer customer)
        {
            //CODE
            return true;
        }//Save
    }
}
