using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Entities
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [MaxLength(500)]      
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Author { get; set; }
        [Required]
        [MaxLength(200)]
        public string Publisher { get; set; }
        [Required]
        [MaxLength(4)]
        public string PublishYear { get; set; }
        [Required]
        public long Price { get; set; }
        public string PhotoName { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
    }
}
