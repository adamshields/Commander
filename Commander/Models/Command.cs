using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Commander
{
    public class Command
    {
        //[Key] - you can use [Key] but not required to use it - by default Id will take it and make it PK
        public int Id { get; set; }
        
        [Required]
        [MaxLength(500)]
        public string HowTo { get; set; }
        
        [Required]
        public string Line { get; set; }
        
        [Required]
        public string Platform { get; set; }
    }
}
