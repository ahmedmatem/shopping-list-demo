using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [DisplayName("Product name")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "The field {0} musht be between {2} and {1}")]
        public string Name { get; set; } = string.Empty;
    }
}
