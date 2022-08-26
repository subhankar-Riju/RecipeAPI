using Microsoft.EntityFrameworkCore;
using RecipeStore.Model;

namespace RecipeStore.Data
{
    public class RecipeDbContext:DbContext
    {
        public RecipeDbContext(DbContextOptions<RecipeDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Ingredients>()
                 .HasKey(x => new { x.IngredientCode, x.RecipeCode });

            

        }

        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
    }
}
