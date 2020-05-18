using Discounty.WebUI.Models;
using Shouldly;
using Xunit;

namespace Discounty.WebUI.UnitTests.Models
{
    public class ProductViewModelTests
    {
        [Fact]
        public void ProductViewModel_WhenConstructorInitializedWithArguments_SummaryTextShouldBeCorrect()
        {
            // arrange
            string name = "someName";
            decimal unitPrice = 5.497m;
            string expectedSummaryText = "someName ($5.50)";

            // act
            var sut = new ProductViewModel(name, unitPrice);

            // assert
            sut.SummaryText.ShouldBe(expectedSummaryText);
        }
    }
}
