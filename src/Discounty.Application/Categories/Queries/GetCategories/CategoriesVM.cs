using System.Collections.Generic;

namespace Discounty.Application.Categories.Queries.GetCategories
{
    /// <summary>
    /// Output get categories data object.
    /// </summary>
    public class CategoriesVM
    {
        /// <summary>
        /// All categories.
        /// </summary>
        public IList<CategoryDTO> Categories { get; set; }
    }
}
