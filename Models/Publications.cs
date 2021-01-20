using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book_MVC.Models
{
    public class Publications
    {
        public int Id { get; set; }
        [Required]
        public string Books_Copies { get; set; }

        public int Publisher_detailId { get; set; }
        public Publisher Publisher_detail { get; set; }

        public int Books_detailId { get; set; }
        public Books Books_detail { get; set; }
    }
}
