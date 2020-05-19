using Discounty.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discounty.Infrastructure.Configurations.Persistence
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Restrict length of the name column
            builder.Property(x => x.Name)
                .HasMaxLength(64)
                .IsRequired();
        }
    }
}
