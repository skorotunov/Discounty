using Discounty.Application.Common.Mappings;
using Discounty.Domain.Entities;

namespace Discounty.Application.Categories.Queries.GetCategories
{
    /// <summary>
    /// Category DTO object which represents info about Category entity.
    /// </summary>
    public class CategoryDTO : IMapFrom<Category>
    {
        /// <summary>
        /// Represents category's name.
        /// </summary>
        public string Name { get; set; }
    }
}
