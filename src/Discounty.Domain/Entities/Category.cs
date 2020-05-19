using System.Collections.Generic;

namespace Discounty.Domain.Entities
{
    /// <summary>
    /// Entity that represents category of the products.
    /// </summary>
    public class Category
    {
        public Category()
        {
            // initialize collections with default values in order to prevent null checks
            Products = new List<Product>();
        }

        /// <summary>
        /// Primary key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the category.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Products of that category.
        /// </summary>
        public IList<Product> Products { get; private set; }
    }
}
