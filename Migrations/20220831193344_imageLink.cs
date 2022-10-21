using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeStore.Migrations
{
    public partial class imageLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImageLinks",
                columns: table => new
                {
                    RecipeCode = table.Column<int>(type: "int", nullable: false),
                    CustomerCode = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageLinks", x => new { x.RecipeCode, x.CustomerCode });
                    table.ForeignKey(
                        name: "FK_ImageLinks_Customers_CustomerCode",
                        column: x => x.CustomerCode,
                        principalTable: "Customers",
                        principalColumn: "CustomerCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImageLinks_Recipes_RecipeCode",
                        column: x => x.RecipeCode,
                        principalTable: "Recipes",
                        principalColumn: "RecipeCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageLinks_CustomerCode",
                table: "ImageLinks",
                column: "CustomerCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageLinks");
        }
    }
}
