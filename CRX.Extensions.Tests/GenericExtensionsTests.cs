using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRX.Extensions.Tests
{
    [TestClass]
    public class GenericExtensionsTests
    {
        [TestMethod]
        [DataRow(5, 5, true, DisplayName = "Contain the specified number")]
        [DataRow(5, 3, false, DisplayName = "Does not contain the specified number")]
        public void In_IntGenerics_ShouldReturnTheExpectedResult(int input, int contains, bool expectedResult)
        {
            // Act
            var result = input.In(contains);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        [DataRow("car", new[] {"car", "truck", "motorbike"}, true, DisplayName = "Contain the specified string")]
        [DataRow("car", new[] { "dog", "cat", "mouse" }, false, DisplayName = "Does not contain the specified string")]
        public void In_StringGenerics_ShouldReturnTheExpectedResult(string input, string[] contains, bool expectedResult)
        {
            // Act
            var result = input.In(contains);
            
            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
