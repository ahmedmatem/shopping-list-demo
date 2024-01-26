using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [DisplayName("Product name")]

        public string Name { get; set; } = string.Empty;
    }
}
