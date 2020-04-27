using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRX.Extensions.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        [DataRow("hello", false, "Hello", DisplayName = "Single lower-case word")]
        [DataRow("hello world", false, "Hello World", DisplayName = "Multiple lower-case words")]
        [DataRow("hello WORLD!", false, "Hello WORLD!", DisplayName = "Lower-case and upper-case words")]
        [DataRow("hello WORLD!", true, "Hello World!", DisplayName = "Lower-case and upper-case words - remove caps words")]
        public void ToTitleCase_String_ShouldReturnAStringInTitleCase(string input, bool replaceCapsWords, string expectedResult)
        {
            // Act
            var result = input.ToTitleCase(replaceCapsWords);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
