using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // arrange
            Customer customer = new Customer();
            customer.FirstName = "Johnnie";
            customer.LastName = "Walker";

            string expected = "Walker, Johnnie";

            // act
            string actual = customer.FullName;

            // assert
            Assert.AreEqual(expected, actual);
        } //FullNameTestValid

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // arrange
            Customer customer = new Customer();
            customer.LastName = "Walker";

            string expected = "Walker";

            // act
            string actual = customer.FullName;

            // assert
            Assert.AreEqual(expected, actual);
        } //FullNameFirstNameEmpty

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // arrange
            Customer customer = new Customer();
            customer.FirstName = "Johnnie";

            string expected = "Johnnie";

            // act
            string actual = customer.FullName;

            // assert
            Assert.AreEqual(expected, actual);
        } //FullNameLastNameEmpty

        [TestMethod]
        public void StaticTest()
        {
            // arrange
            var c1 = new Customer();
            c1.FirstName = "Johnnie";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Willy";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Bobby";
            Customer.InstanceCount += 1;

            // act

            // assert
            Assert.AreEqual(3, Customer.InstanceCount);
        } //StaticTest

        [TestMethod]
        public void ValidateValid()
        {
            //arrange
            var customer = new Customer();
            customer.LastName = "Walker";
            customer.Email = "jwalker@test.com";

            var expected = true;

            //act
            var actual = customer.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        } //ValidateValid

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //arrange
            var customer = new Customer();
            customer.Email = "jwalker@test.com";

            var expected = false;

            //act
            var actual = customer.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        } //ValidateMissingLastName

        [TestMethod]
        public void ValidateMissingEmail()
        {
            //arrange
            var customer = new Customer();
            customer.LastName = "Walker";

            var expected = false;

            //act
            var actual = customer.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        } //ValidateMissingEmail

        [TestMethod]
        public void ValidateMissingEmailAndLastName()
        {
            //arrange
            var customer = new Customer();

            var expected = false;

            //act
            var actual = customer.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        } //ValidateMissingEmailAndLastName
    }
}
