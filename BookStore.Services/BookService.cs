using BookStore.Entities;
using BookStore.Repositories.Interfaces;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(Book book)
        {
            _bookRepository.AddBook(book);
        }

        public void Delete(int bookID)
        {
            _bookRepository.DeleteBook(bookID);
        }

        public void Edit(Book book)
        {
            _bookRepository.EditBook(book);
        }

        public void Edit(int id)
        {
            _bookRepository.EditBook(id);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            var result = _bookRepository.GetAllBooks();
            return result;
        }

        public Book GetBookByID(int id)
        {
            var result = _bookRepository.GetBookByID(id);
            return result;
        }

        #region Helper Function
        public Tuple<List<SelectListItem>, List<SelectListItem>, List<SelectListItem>> FillDropdowns(
            IEnumerable<Category> categories,
            IEnumerable<Author> authors,
            IEnumerable<Publisher> publishers)
        {
            List<SelectListItem> Categories = new List<SelectListItem>
            {
                new SelectListItem {Value= "0" , Text = "Select Category..."}
            };

            List<SelectListItem> Authors = new List<SelectListItem>
            {
                new SelectListItem {Value= "0" , Text = "Select Author..."}
            };

            List<SelectListItem> Publishers = new List<SelectListItem>
            {
                new SelectListItem {Value= "0" , Text = "Select Publisher..."}
            };

            foreach (var category in categories)
            {

                Categories.Add(new SelectListItem { Value = category.ID.ToString(), Text = category.Name });

            }

            foreach (var author in authors)
            {

                Authors.Add(new SelectListItem { Value = author.ID.ToString(), Text = author.Name });

            }

            foreach (var publisher in publishers)
            {

                Publishers.Add(new SelectListItem { Value = publisher.ID.ToString(), Text = publisher.Name });

            }

            #region Old Static Code
            //List<SelectListItem> Categories = new List<SelectListItem>
            //{
            //    new SelectListItem(){Text="Romance",Value="1" ,Selected=true},
            //    new SelectListItem(){Text="Drama",Value="2"},
            //    new SelectListItem(){Text="Adveture",Value="3"}

            //};



            //List<SelectListItem> Authors = new List<SelectListItem>
            //{
            //    new SelectListItem(){Text="Agatha Cristie",Value="1" ,Selected=true},
            //    new SelectListItem(){Text="Sephen King",Value="2"},
            //    new SelectListItem(){Text="William Shakespaeare",Value="3"}

            //};


            //List<SelectListItem> Publishers = new List<SelectListItem>
            //{
            //    new SelectListItem(){Text="AC",Value="1" ,Selected=true},
            //    new SelectListItem(){Text="SK",Value="2"},
            //    new SelectListItem(){Text="WS",Value="3"}

            //};
            #endregion


            return Tuple.Create(Categories, Authors, Publishers);
        }
        #endregion
    }
}
