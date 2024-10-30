using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rmbh.Entity.Entities.Manipulation;

namespace rmbh.Entity.Configurations
{
    public class UserDeckStatisticConfiguration : IEntityTypeConfiguration<UserDeckStatistic>
    {
        public void Configure(EntityTypeBuilder<UserDeckStatistic> builder)
        {
            builder.ToTable("UserDeckStatistics");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.HasOne(x => x.Deck).WithMany(x => x.UserDeckStatistics).HasForeignKey(x => x.DeckId);
            builder.HasOne(x => x.User).WithMany(x => x.UserDeckStatistics).HasForeignKey(x => x.UserId);
        }
    }
}
