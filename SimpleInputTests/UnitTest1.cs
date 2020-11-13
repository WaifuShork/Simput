using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleInputs;

namespace SimpleInputTests
{
    [TestClass]
    public class NextInputTests
    {
        [TestMethod]
        public void NextDecimal_InputIsDecimal_ReturnsDecimal()
        {
            // Arrange
            var decimalInput = Input.NextDecimal();
            decimalInput.Equals(12);
        }
    }
}