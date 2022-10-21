using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeStore.Data
{
    public class Customers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerCode { get; set; }   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string pass_code { get; set; }   

        public List<RecipeIngredient> RecipeIngredients { get; set; }
        public List<ImageLinks> ImageLinks { get; set; }    
    }
}
