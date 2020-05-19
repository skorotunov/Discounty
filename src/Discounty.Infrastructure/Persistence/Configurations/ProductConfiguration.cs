using Discounty.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discounty.Infrastructure.Configurations.Persistence
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Restrict length of the name column
            builder.Property(x => x.Name)
                .HasMaxLength(128)
                .IsRequired();
        }
    }
}
