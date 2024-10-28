using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rmbh.Entity.Entities.Manipulation;

namespace rmbh.Entity.Configurations
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("Classes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn().IsRequired();
        }
    }
}
