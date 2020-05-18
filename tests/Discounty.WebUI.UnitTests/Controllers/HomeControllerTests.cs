using Discounty.WebUI.Controllers;
using Discounty.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Shouldly;
using Xunit;

namespace Discounty.WebUI.UnitTests.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_OnCall_ShouldReturnViewWithCorrectModel()
        {
            // arrange
            var sut = new HomeController();

            // act
            IActionResult result = sut.Index();

            // assert
            result.ShouldBeOfType<ViewResult>();
            (result as ViewResult).ViewData.Model.ShouldBeOfType<FeaturedProductsViewModel>();
        }
    }
}
