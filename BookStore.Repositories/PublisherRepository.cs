using BookStore.Data;
using BookStore.Entities;
using BookStore.Entities.Loger;
using BookStore.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Repositories
{
    public class PublisherRepository : IPublisherRepository
    {

        private readonly DataContext _context;

        public PublisherRepository(DataContext context)
        {

            _context = context;
        }

        public void AddPublisher(Publisher publisher)
        {
      
                _context.Publishers.Add(publisher);
                _context.SaveChanges();


        }

        public void DeletePublisher(int publisherId)
        {
          
                Publisher publisher = GetPublisherById(publisherId);
                _context.Publishers.Remove(publisher);
                _context.SaveChanges();

        }

        public void EditPublisher(Publisher publisher)
        {
       
                _context.Publishers.Update(publisher);
                _context.SaveChanges();

        }

        public IEnumerable<Publisher> GetAllPublishers()
        {
            var result = _context.Publishers.AsEnumerable();
            return result;
        }

        public Publisher GetPublisherById(int id)
        {
            var result = _context.Publishers.FirstOrDefault(x => x.ID == id);
            return result;
        }
    }
}
