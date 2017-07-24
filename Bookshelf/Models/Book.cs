using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Book
    {
        //When you are building a model in C#, you will ALWAYS want an ID!!
        //Primary Key
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        //ForeignKey establishes relationship with another class (or table)
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        //Navigation Property
        public virtual Category Category { get; set; }
    }
}