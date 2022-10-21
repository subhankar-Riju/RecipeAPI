namespace RecipeStore.Repository
{
    public interface IRecipeQuery
    {
        Task<object> GetAllRecipeAsync();
        Task<object> GetByRecipeAndClient(string recipeCode, string CustomerCode);
    }
}
