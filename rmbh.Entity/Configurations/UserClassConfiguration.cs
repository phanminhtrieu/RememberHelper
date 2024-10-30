using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rmbh.Entity.Entities.Manipulation;

namespace rmbh.Entity.Configurations
{
    public class UserClassConfiguration : IEntityTypeConfiguration<UserClass>
    {
        public void Configure(EntityTypeBuilder<UserClass> builder)
        {
            builder.ToTable("UserClasses");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn().IsRequired();
            builder.HasOne(x => x.User).WithMany(x => x.UserClasses).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Class).WithMany(x => x.UserClasses).HasForeignKey(x => x.ClassId);
        }
    }
}
