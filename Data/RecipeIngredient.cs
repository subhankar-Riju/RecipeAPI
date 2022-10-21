using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeStore.Data
{
    public class RecipeIngredient
    {
        
        
        public int CustomerCode { get; set; }   
        public int RecipeCode { get; set; }
        public int Ingredientcode { get; set; }
        [Column(TypeName ="decimal(10,4)")]
        public float Quantity { get; set; }

        public Ingredients Ingredients { get; set; }
        public RecipeItem Recipe { get; set; }
        public Customers Customers { get; set; }    
    }
}
