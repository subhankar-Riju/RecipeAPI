using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeStore.Migrations
{
    public partial class change1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredient_Customers_Ingredientcode",
                table: "RecipeIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredient_Ingredients_Ingredientcode",
                table: "RecipeIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredient_Recipes_RecipeCode",
                table: "RecipeIngredient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeIngredient",
                table: "RecipeIngredient");

            migrationBuilder.RenameTable(
                name: "RecipeIngredient",
                newName: "RecipeIngredients");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredient_Ingredientcode",
                table: "RecipeIngredients",
                newName: "IX_RecipeIngredients_Ingredientcode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeIngredients",
                table: "RecipeIngredients",
                columns: new[] { "RecipeCode", "Ingredientcode", "CustomerCode" });

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Customers_Ingredientcode",
                table: "RecipeIngredients",
                column: "Ingredientcode",
                principalTable: "Customers",
                principalColumn: "CustomerCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Ingredients_Ingredientcode",
                table: "RecipeIngredients",
                column: "Ingredientcode",
                principalTable: "Ingredients",
                principalColumn: "IngredientCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Recipes_RecipeCode",
                table: "RecipeIngredients",
                column: "RecipeCode",
                principalTable: "Recipes",
                principalColumn: "RecipeCode",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Customers_Ingredientcode",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Ingredients_Ingredientcode",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Recipes_RecipeCode",
                table: "RecipeIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeIngredients",
                table: "RecipeIngredients");

            migrationBuilder.RenameTable(
                name: "RecipeIngredients",
                newName: "RecipeIngredient");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredients_Ingredientcode",
                table: "RecipeIngredient",
                newName: "IX_RecipeIngredient_Ingredientcode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeIngredient",
                table: "RecipeIngredient",
                columns: new[] { "RecipeCode", "Ingredientcode", "CustomerCode" });

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredient_Customers_Ingredientcode",
                table: "RecipeIngredient",
                column: "Ingredientcode",
                principalTable: "Customers",
                principalColumn: "CustomerCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredient_Ingredients_Ingredientcode",
                table: "RecipeIngredient",
                column: "Ingredientcode",
                principalTable: "Ingredients",
                principalColumn: "IngredientCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredient_Recipes_RecipeCode",
                table: "RecipeIngredient",
                column: "RecipeCode",
                principalTable: "Recipes",
                principalColumn: "RecipeCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
