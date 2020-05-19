using AutoMapper;
using AutoMapper.QueryableExtensions;
using Discounty.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Discounty.Application.Categories.Queries.GetCategories
{
    /// <summary>
    /// Handler of the query. Gets incoming data and outputs desired view model.
    /// </summary>
    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, CategoriesVM>
    {
        private readonly IDbContext context;
        private readonly IMapper mapper;

        public GetCategoriesQueryHandler(IDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<CategoriesVM> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            return new CategoriesVM()
            {
                Categories = await context.Categories
                    .AsNoTracking()
                    .ProjectTo<CategoryDTO>(mapper.ConfigurationProvider)
                    .ToListAsync()
            };
        }
    }
}
