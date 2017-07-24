using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Category")]
        public string Name { get; set; }
        //Navigation Property
        public virtual ICollection<Book> Books { get; set; }
    }
}