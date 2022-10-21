using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeStore.Repository;

namespace RecipeStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueryController : ControllerBase
    {
        private readonly IRecipeQuery _recipe;

        public QueryController(IRecipeQuery recipe)
        {
            _recipe = recipe;
        }

        [HttpGet]
        public async Task<IActionResult> SEQ()
        {
            var result=await _recipe.GetAllRecipeAsync();

            return Ok(result);
        }

        [HttpGet("/GetAllByClientAndRecipe/{recipeCode}/{clientCode}")]

        public async Task<IActionResult> GetAllByClientAndRecipe([FromRoute]string recipeCode,
            [FromRoute]string clientCode)
        {
            var result=await _recipe.GetByRecipeAndClient(recipeCode, clientCode);
            return Ok(result);
        }
    }
}
