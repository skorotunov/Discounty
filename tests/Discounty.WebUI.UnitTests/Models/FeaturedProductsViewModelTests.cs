using Discounty.WebUI.Models;
using System.Collections.Generic;
using Xunit;

namespace Discounty.WebUI.UnitTests.Models
{
    public class FeaturedProductsViewModelTests
    {
        [Fact]
        public void FeaturedProductsViewModel_WhenConstructorInitializedWithArgument_ShouldAssigneCorrectCollection()
        {
            // arrange
            var products = new List<ProductViewModel>() { new ProductViewModel("name1", 2.45m), new ProductViewModel("name2", 4.53m) };

            // act
            var sut = new FeaturedProductsViewModel(products);

            // assert
            Assert.Equal(sut.Products, products);
        }
    }
}
