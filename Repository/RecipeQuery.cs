using Microsoft.EntityFrameworkCore;
using RecipeStore.Data;
using RecipeStore.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace RecipeStore.Repository
{
    public class RecipeQuery : IRecipeQuery
    {
        private readonly RecipeDbContext _context;

        public RecipeQuery(RecipeDbContext context)
        {
            _context = context;
        }

       /* public async Task<Object> AddRecipesAsync(RecipeModel recipe, IngredientsModel ingredients )
        {

        }*/

        public async Task<object> GetAllRecipeAsync()
        {


            var result = from r in _context.Recipes
                         join ri in _context.RecipeIngredients on r.RecipeCode equals ri.RecipeCode
                         join c in _context.Customers on ri.CustomerCode equals c.CustomerCode
                         join img in _context.ImageLinks on new { c.CustomerCode, ri.RecipeCode } 
                         equals new {img.CustomerCode,img.RecipeCode}
                         select (new
                         {

                             RecipeId = r.RecipeCode,
                             CustomerId = ri.CustomerCode,
                             RecipeName = r.RecipeName,
                             CustomerName= c.FirstName +' '+ c.LastName,
                             ImagePath=img.ImagePath,
                         });
          var re = await result.Distinct().ToListAsync();
            return re;

        }

        public async Task<object> GetByRecipeAndClient(string recipeCode,string CustomerCode)
        {
            var result = from r in _context.Recipes
                         join ri in _context.RecipeIngredients on r.RecipeCode equals ri.RecipeCode
                         join c in _context.Customers on ri.CustomerCode equals c.CustomerCode
                         join ing in _context.Ingredients on ri.Ingredientcode equals ing.IngredientCode
                         join img in _context.ImageLinks on new { c.CustomerCode, ri.RecipeCode }
                         equals new { img.CustomerCode, img.RecipeCode }

                         select (new
                         {
                             RecipeName=r.RecipeName,
                             CustomerFirstName=c.FirstName,
                             CustomerLastName=c.LastName,
                             PreparationTime=r.PreparationTime,
                             Ingredient=ing.IngredientName,
                             Quantity=ri.Quantity,
                             Unit=ing.Unit,
                             ImagePath=img.ImagePath
                         });

            var re = await result.ToListAsync();
            var re1 = re.Select(a => new
            {
                RecipeName = a.RecipeName,
                CustomerFirstName = a.CustomerFirstName,
                CustomerLastName = a.CustomerLastName,
                PreparationTime = a.PreparationTime,
                ImagePath = a.ImagePath,

            });
            var re2 = re1.Distinct().ToList();

            var re3 = re.Select(a => new
            {
                Quantity = a.Quantity,
                Unit = a.Unit,
                Ingredient = a.Ingredient
            });

            return new
            {
                Recipes=re2,
                ingredients=re3
            };

        }
     

    }
}
