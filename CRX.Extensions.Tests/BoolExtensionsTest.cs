using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRX.Extensions.Tests
{
    [TestClass]
    public class BoolExtensionsTest
    {
        [TestMethod]
        [DataRow(true, "Yes", DisplayName = "Returns Yes")]
        [DataRow(false, "No", DisplayName = "Returns No")]
        public void ToYesNo_Bool_ReturnsYesOrNoAccordingToInput(bool input, string expectedResult)
        {
            // Act
            var result = input.ToYesNo();

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
