using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        [DataRow(TestEnum.Item1, "Item1", DisplayName = "Enum item without underscores")]
        [DataRow(TestEnum.Item_2, "Item 2", DisplayName = "Enum item with underscores")]
        public void ToDisplay_Enum_ShouldReturnTheExpectedResult(Enum input, string expectedResult)
        {
            // Act
            var result = input.ToDisplay();

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
