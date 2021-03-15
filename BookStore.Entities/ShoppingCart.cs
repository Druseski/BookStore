using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStore.Entities
{
    public class ShoppingCart
    {
        [Key]
        public int ID { get; set; }

        public string UserID { get; set; }

        public int BookID { get; set; }

        public double Price { get; set; }

        public double Discount { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
