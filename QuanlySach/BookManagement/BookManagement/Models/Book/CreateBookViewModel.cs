using BookManagement.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Models.Book
{
    public class CreateBookViewModel
    {
        
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
        [Required]
        public int CategoryId { get; set; }      
        
    }
}
