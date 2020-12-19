using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetDuds.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        // add reference to child object
        public List<Product> Products { get; set; }
    }
}
