using System.Collections.Generic;

namespace Discounty.WebUI.Models
{
    public class FeaturedProductsViewModel
    {
        public FeaturedProductsViewModel(IEnumerable<ProductViewModel> products)
        {
            Products = products;
        }

        public IEnumerable<ProductViewModel> Products { get; }
    }
}
