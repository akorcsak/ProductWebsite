using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductApp.Models
{
    public class ReviewModels
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Range(0, 5)]
        public int Rating { get; set; }

        [Required]
        public string Description { get; set; }
    }
}