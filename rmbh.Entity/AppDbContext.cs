using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using rmbh.Entity.Configurations;
using rmbh.Entity.Entities.Manipulation;
using rmbh.Entity.Extensions;
using rmbh.Entity.Interfaces;

namespace rmbh.Entity
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        {
        }

        // User
        public DbSet<User> Users { get; set; }
        public DbSet<UserClass> UserClasses { get; set; }
        
        // Flash card
        public DbSet<Class> Classes { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserClassConfiguration());


            // Flash card
            modelBuilder.ApplyConfiguration(new ClassConfiguration());
            modelBuilder.ApplyConfiguration(new DeckConfiguration());
            modelBuilder.ApplyConfiguration(new CardConfiguration());

            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=.; Database=rmbh; Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);

            foreach (EntityEntry item in modified)
            {
                var changedOrAddedItem = item.Entity as IHasDateTracking;

                if (changedOrAddedItem != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        changedOrAddedItem.CreatedDate = DateTime.Now;
                    }
                    changedOrAddedItem.ModifiedDate = DateTime.Now;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
