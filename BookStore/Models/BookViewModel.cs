using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BookViewModel
    {
        //************BookData

        public string Title { get; set; }

        public string AuthorName { get; set; }
       
        public int AuthorID { get; set; }

        public Author Author { get; set; }

        public DateTime YearOfIssue { get; set; }

        public int NumberOfPages { get; set; }

        public string PublisherName { get; set; }
        
        public int PublisherID { get; set; }

        public Publisher Publisher { get; set; }

        public int UserID { get; set; }

        
        public string Genre { get; set; }
        
        public string CategoryName { get; set; }
       
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        [StringLength(50)]
        public string BookType { get; set; }

        [StringLength(50)]
        public string BookCoverType { get; set; }

        public double Price { get; set; }

        [StringLength(1500)]
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

        //************ AuthorData

        public string AuthorNameDTO { get; set; }

        
        public string AuthorCountryDTO { get; set; }

        public DateTime AuthorDateBirthDTO { get; set; }

       [StringLength(1500)]
        public string AuthorShortDiscriptionDTO { get; set; }

        
        public string AuthorLanguageDTO { get; set; }

        
        public string AuthorGenderDTO { get; set; }

        public bool AuthorPopularityDTO  { get; set; }

        //************ PublisherData

        [StringLength(100)]
        public string PublisherNameDTO { get; set; }

        [StringLength(100)]
        public string PublisherCountryDTO { get; set; }

        [StringLength(50)]
        public string PublisherYearDTO { get; set; }

        // ************CategoryData

        [StringLength(100)]
        public string CategoryNameDTO { get; set; }

    }
}
