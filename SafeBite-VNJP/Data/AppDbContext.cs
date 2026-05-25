using Microsoft.EntityFrameworkCore;
using SafeBite_VNJP.Models;

namespace SafeBite_VNJP.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<IngredientPost> IngredientPosts { get; set; }

        public DbSet<DietaryTag> DietaryTags { get; set; }

        public DbSet<RestaurantDietaryTag> RestaurantDietaryTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RestaurantDietaryTag>()
                .HasKey(rdt => new
                {
                    rdt.RestaurantId,
                    rdt.DietaryTagId
                });
        }
    }
}