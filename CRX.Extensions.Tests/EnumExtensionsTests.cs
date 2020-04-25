using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRX.Extensions.Tests
{
    [TestClass]
    public class EnumExtensionsTests
    {
        public enum TestEnum
        {
            Item1,
            Item_2,
            Item3
        }

        [TestMethod]
        [DataRow(TestEnum.Item1, "Item1", DisplayName = "")]
        [DataRow(TestEnum.Item_2, "Item 2", DisplayName = "")]
        public void ToDisplay_Enum_ShouldReturnTheExpectedResult(Enum input, string expectedResult)
        {
            // Arrange

            // Act
            var result = input.ToDisplay();

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
