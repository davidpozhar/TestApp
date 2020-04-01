using NormMVC.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NormMVC.Models
{
    public class Product : IEntityModel<int>
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the product's name")]
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        [NotMapped]
        public string FullDescription { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { set; get; }
    }
}