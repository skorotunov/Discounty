using MediatR;

namespace Discounty.Application.Categories.Queries.GetCategories
{
    /// <summary>
    /// Input data to the get categories query.
    /// </summary>
    public class GetCategoriesQuery : IRequest<CategoriesVM>
    {
    }
}
