 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStore.Entities
{
    public class Book
    {
        [Key]
        public int ID { get; set; }

        [StringLength(350)]
        public string Title { get; set; }

        [StringLength(350)]
        public string AuthorName { get; set; }

        public int AuthorID { get; set; }

        public Author Author { get; set; }

        public DateTime YearOfIssue { get; set; }

        public int NumberOfPages { get; set; }

        [StringLength(350)]

        public string PublisherName { get; set; }

        public int PublisherID { get; set; }

        public Publisher Publisher { get; set; }

        public int UserID { get; set; }

        [StringLength(150)]
        public string Genre { get; set; }

        public string CategoryName { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        [StringLength(50)]
        public string BookType { get; set; }

        [StringLength(50)]
        public string BookCoverType { get; set; }

        public double Price { get; set; }

        [StringLength(500)]
        public string Discription { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        [StringLength(150)]
        public string Country { get; set; }

        public int Edition { get; set; }

        [StringLength(50)]
        public string Dimension { get; set; }

        public double Weight { get; set; }

        public int Copies { get; set; }

        [StringLength(50)]
        public string Shipping { get; set; }

        public string PhotoURL { get; set; }

        public int SoldItems { get; set; }

        public double Rating { get; set; }

        public DateTime DateAdded { get; set; }

        
       

        //public virtual ICollection<Photo> Photos { get; set; }
    }
}
