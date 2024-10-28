using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rmbh.Entity.Entities.Manipulation;

namespace rmbh.Entity.Configurations
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.ToTable("Cards");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn().IsRequired();
            builder.HasOne(x => x.Deck).WithMany(x => x.Cards).HasForeignKey(x => x.DeckId);
        }
    }
}
