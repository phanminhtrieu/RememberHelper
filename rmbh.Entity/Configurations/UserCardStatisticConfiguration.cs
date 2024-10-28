using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rmbh.Entity.Entities.Manipulation;

namespace rmbh.Entity.Configurations
{
    public class UserCardStatisticConfiguration : IEntityTypeConfiguration<UserCardStatistic>
    {
        public void Configure(EntityTypeBuilder<UserCardStatistic> builder)
        {
            builder.ToTable("UserCardStatistics");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.HasOne(x => x.User).WithMany(x => x.UserCardStatistics).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Card).WithMany(x => x.UserCardStatistics).HasForeignKey(x => x.CardId);
        }
    }
}
