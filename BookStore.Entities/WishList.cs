using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStore.Entities
{
    public class WishList
    {
        [Key]
        public int ID { get; set; }

        public string UserID { get; set; }
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public int CategoryID { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
