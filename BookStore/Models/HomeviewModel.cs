using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class HomeviewModel
    {
        public IEnumerable<Book> AllBooksList { get; set; }


    }
}
