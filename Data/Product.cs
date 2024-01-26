using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Data
{
    [Comment("Product entity")]
    public class Product
    {
        [Key]
        [Comment("Product Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Comment("Product name.")]
        public string Name { get; set; } = string.Empty;

        [Comment("Product notes.")]
        public List<ProductNote> ProductNotes { get; set; } = new List<ProductNote>();
    }
}
