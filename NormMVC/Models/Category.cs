using NormMVC.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NormMVC.Models
{
    public class Category : IEntityModel<int>
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}