// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeStore.Data;

#nullable disable

namespace RecipeStore.Migrations
{
    [DbContext(typeof(RecipeDbContext))]
    [Migration("20220830085817_pk added")]
    partial class pkadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RecipeStore.Data.Customers", b =>
                {
                    b.Property<int>("CustomerCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerCode"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pass_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerCode");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RecipeStore.Data.Ingredients", b =>
                {
                    b.Property<int>("IngredientCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientCode"), 1L, 1);

                    b.Property<string>("IngredientName")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.HasKey("IngredientCode");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("RecipeStore.Data.RecipeIngredient", b =>
                {
                    b.Property<int>("RecipeCode")
                        .HasColumnType("int");

                    b.Property<int>("Ingredientcode")
                        .HasColumnType("int");

                    b.Property<int>("CustomerCode")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(10,4)");

                    b.HasKey("RecipeCode", "Ingredientcode", "CustomerCode");

                    b.HasIndex("Ingredientcode");

                    b.ToTable("RecipeIngredient");
                });

            modelBuilder.Entity("RecipeStore.Data.RecipeItem", b =>
                {
                    b.Property<int>("RecipeCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeCode"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<decimal>("PreparationTime")
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("RecipeName")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.HasKey("RecipeCode");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("RecipeStore.Data.RecipeIngredient", b =>
                {
                    b.HasOne("RecipeStore.Data.Customers", "Customers")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("Ingredientcode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeStore.Data.Ingredients", "Ingredients")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("Ingredientcode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeStore.Data.RecipeItem", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");

                    b.Navigation("Ingredients");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("RecipeStore.Data.Customers", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("RecipeStore.Data.Ingredients", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("RecipeStore.Data.RecipeItem", b =>
                {
                    b.Navigation("RecipeIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
