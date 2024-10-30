using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rmbh.Entity.Entities.Manipulation;

namespace rmbh.Entity.Configurations
{
    public class UserClassStatisticConfiguration : IEntityTypeConfiguration<UserClassStatistic>
    {
        public void Configure(EntityTypeBuilder<UserClassStatistic> builder)
        {
            builder.ToTable("UserClassStatistics");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.HasOne(x => x.Class).WithMany(x => x.UserClassStatistics).HasForeignKey(x => x.ClassId);
            builder.HasOne(x => x.User).WithMany(x => x.UserClassStatistics).HasForeignKey(x => x.UserId);
        }
    }
}
