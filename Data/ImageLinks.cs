using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeStore.Data
{
    public class ImageLinks
    {
        public int RecipeCode { get; set; }
        public int CustomerCode { get; set; }
        [Column(TypeName ="varchar(max)")]
        public string ImagePath { get; set; }

        public Customers Customers { get; set; }    
        public RecipeItem RecipeItem { get; set; }
    }
}
