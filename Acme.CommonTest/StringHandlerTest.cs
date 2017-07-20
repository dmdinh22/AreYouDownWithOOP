using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // arrange
            var source = "SonicTheHedgehog";
            var expected = "Sonic The Hedgehog";

            // act
            var actual = source.InsertSpaces();

            // assert
            Assert.AreEqual(expected, actual);
        } //InsertSpacesTestValid

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            // arrange
            var source = "Sonic The Hedgehog";
            var expected = "Sonic The Hedgehog";

            // act
            var actual = source.InsertSpaces();

            // assert
            Assert.AreEqual(expected, actual);
        } //InsertSpacesTestWithExistingSpace
    }
}
