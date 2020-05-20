using Discounty.Application.Categories.Queries.GetCategories;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Discounty.WebUI.Controllers
{
    public class CategoriesController : ApiController
    {
        public CategoriesController(IMediator mediator)
            : base(mediator)
        {
        }

        [HttpGet]
        public async Task<ActionResult<CategoriesVM>> Get()
        {
            return await Mediator.Send(new GetCategoriesQuery());
        }
    }
}
