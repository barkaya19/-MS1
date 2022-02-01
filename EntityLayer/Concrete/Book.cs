using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Writer { get; set; }
        [Required]
        public int PageNumber { get; set; }
        [Required]
        public string Summary { get; set; }
    }
}
