using Microsoft.EntityFrameworkCore;


namespace RecipeStore.Data
{
    public class RecipeDbContext:DbContext
    {
        public RecipeDbContext(DbContextOptions<RecipeDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredient>()
                .HasKey(ri => new { ri.RecipeCode, ri.Ingredientcode , ri.CustomerCode});

            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Recipe)
                .WithMany(i => i.RecipeIngredients)
                .HasForeignKey(ri => ri.RecipeCode);

            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri=>ri.Ingredients)
                .WithMany(i => i.RecipeIngredients)
                .HasForeignKey(ri=>ri.Ingredientcode);

            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Customers)
                .WithMany(i => i.RecipeIngredients)
                .HasForeignKey(ri => ri.Ingredientcode);

            modelBuilder.Entity<ImageLinks>()
                .HasKey(i => new { i.RecipeCode, i.CustomerCode });

            modelBuilder.Entity<ImageLinks>()
                .HasOne(il => il.Customers)
                .WithMany(c => c.ImageLinks)
                .HasForeignKey(il => il.CustomerCode);

            modelBuilder.Entity<ImageLinks>()
                .HasOne(il => il.RecipeItem)
                .WithMany(c => c.ImageLinks)
                .HasForeignKey(il => il.RecipeCode);





















        }

        public DbSet<RecipeItem> Recipes { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<Customers>  Customers { get; set; }
        public DbSet<ImageLinks> ImageLinks { get; set; }
    }
}
