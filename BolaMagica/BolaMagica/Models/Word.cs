using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BolaMagica.Models
{
    public class Word
    {
        [Key]
        [Required]
        public int WordId { get; set; }
        [Required]
        public string WordMessage { get; set; }
    }
}