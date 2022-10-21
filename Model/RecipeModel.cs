using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeStore.Model
{
    public class RecipeModel
    {
       
        public string RecipeCode { get; set; }
        
        public string Description { get; set; }
        
        public float PreparationTime { get; set; }

        
    }
}
