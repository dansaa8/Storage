using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A product name is required")]
        [DisplayName("Product Name")]
        [StringLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "A price must be set")]
        [Range(0.01, 2000.00,
            ErrorMessage = "Price must be between 0.01 and 2000.00")]
        public double Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "A category must be provided")]
        public string Category { get; set; }

        [Required(ErrorMessage = "A shelf must be entered")]
        public string Shelf { get; set; }

        [Required(ErrorMessage = "An item count must be provided")]
        public int Count { get; set; }

        public string Description { get; set; }
    }
}
