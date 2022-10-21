using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeStore.Data
{
    public class RecipeItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeCode { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string RecipeName { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string Description { get; set; }
        [Column(TypeName = "decimal(10,4)")]
        public float PreparationTime { get; set; }

        public List<RecipeIngredient> RecipeIngredients { get; set; }  
        public List<ImageLinks> ImageLinks { get; set; }
    }
}
