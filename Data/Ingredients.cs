using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeStore.Data
{
    public class Ingredients
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  IngredientCode { get; set; }
        [Column(TypeName ="varchar(max)")]
        public string IngredientName { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string Unit { get; set; }

        public List<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
