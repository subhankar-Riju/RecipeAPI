using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeStore.Model
{
    public class IngredientsModel
    {
        
        public string IngredientCode { get; set; }
        
        public string RecipeCode { get; set; }

        public float Quantity { get; set; }
    
        public string Unit { get; set; }

       

    }
}
