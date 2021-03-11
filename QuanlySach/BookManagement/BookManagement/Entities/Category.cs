using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Entities
{
    public class Category
    {
        [Key]       
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public IEnumerable<Book> Books { get; set; }
    }
}
