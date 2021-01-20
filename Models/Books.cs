using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book_MVC.Models
{
    public class Books
    {
        public int Id { get; set; }
        [Required]
        public string Tittle { get; set; }

        public string Discription { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int AuthorId { get; set; }
        public Authors Author { get; set; }
    }
}
