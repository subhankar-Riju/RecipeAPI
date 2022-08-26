using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeStore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientCode = table.Column<string>(type: "varchar(900)", nullable: false),
                    RecipeCode = table.Column<string>(type: "varchar(900)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Unit = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => new { x.IngredientCode, x.RecipeCode });
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    RecipeCode = table.Column<string>(type: "varchar(900)", nullable: false),
                    Description = table.Column<string>(type: "varchar(max)", nullable: false),
                    PreparationTime = table.Column<decimal>(type: "decimal(10,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.RecipeCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipe");
        }
    }
}
