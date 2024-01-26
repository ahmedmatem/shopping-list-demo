using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingList.Data
{
    [Comment("Product note entity")]
    public class ProductNote
    {
        [Key]
        [Comment("Note Identifier")]
        public int Id { get; set; }

        [Comment("Product note content")]
        [Required]
        [StringLength(150)]
        public string Content { get; set; } = string.Empty;

        [Required]
        [Comment("Product Identifier")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}