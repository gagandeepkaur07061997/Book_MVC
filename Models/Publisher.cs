using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book_MVC.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        [Required]
        public string Publisher_Name { get; set; }
        public string Mobile_Number { get; set; }
        public string Email_Id { get; set; }

    }
   
}
