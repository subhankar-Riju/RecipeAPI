using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeStore.Model
{
    public class Ingredients
    {
        [Key]
        [Column(TypeName ="varchar(900)")]
        public string IngredientCode { get; set; }
        [Key]
        [Column(TypeName = "varchar(900)")]
        public string RecipeCode { get; set; }
        [Column(TypeName = "decimal(10,4)")]
        public float Quantity { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string Unit { get; set; }

    }
}
