using BookStore.Data;
using BookStore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repositories
{
    public class WishListRepository : IWishListRepository
    {
        private readonly DataContext _context;

        public WishListRepository(DataContext context)
        {
            _context = context;
        }
    }
}
