using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRX.Extensions.Tests
{
    [TestClass]
    public class BoolExtensionsTests
    {
        [TestMethod]
        [DataRow(true, "Yes", DisplayName = "True boolean value")]
        [DataRow(false, "No", DisplayName = "False boolean value")]
        public void ToYesNo_Bool_ReturnsYesOrNoAccordingToInput(bool input, string expectedResult)
        {
            // Act
            var result = input.ToYesNo();

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
