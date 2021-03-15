using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStore.Entities
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        public string UserID { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string BookCountry { get; set; }
        public string BookPublisher { get; set; }
        public string BookCategory { get; set; }
        public string BookType { get; set; }
        public string BookDimension { get; set; }
        public string BookWeight { get; set; }        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        
    }
}
