using Discounty.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Discounty.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            var vm = new FeaturedProductsViewModel(new[]
            {
                new ProductViewModel("Chocolate", 34.95m),
                new ProductViewModel("Asparagus", 39.80m)
            });
            return View(vm);
        }
    }
}
