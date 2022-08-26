using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeStore.Model
{
    public class Recipe
    {
        [Key]
        [Column(TypeName = "varchar(900)")]
        public string RecipeCode { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string Description { get; set; }
        [Column(TypeName = "decimal(10,4)")]
        public float PreparationTime { get; set; }
        
    }
}
