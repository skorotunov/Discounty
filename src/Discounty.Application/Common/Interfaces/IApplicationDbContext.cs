using Discounty.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Discounty.Application.Common.Interfaces
{
    /// <summary>
    /// Service which represents system database context. EF core dbcontext represents Unit of Work.
    /// </summary>
    public interface IApplicationDbContext
    {
        /// <summary>
        /// Repository of the Category entities.
        /// </summary>
        DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Repository of the Product entities.
        /// </summary>
        DbSet<Product> Products { get; set; }

        /// <summary>
        /// Commit changes to the databasy in async way.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to cancell task.</param>
        /// <returns>Result of the database commit.</returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
