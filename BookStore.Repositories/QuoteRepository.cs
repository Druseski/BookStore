using BookStore.Data;
using BookStore.Entities.Quotes;
using BookStore.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repositories
{
    public class QuoteRepository : IQuoteRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<QuoteRepository> _logger;

        public QuoteRepository(DataContext context, ILogger<QuoteRepository> logger)
        {
            _logger = logger;
            _context = context;
        }
        public void AddQuote(QuoteMap quote)
        {
            try
            {
                _context.Quotes.Add(quote);
                _context.SaveChanges();
                _logger.LogInformation("Quote Addet to DB");
            }
            catch (Exception ex)
            {
                _logger.LogError("Quote NOT Added to DB" + "|" + ex);
                throw;
            }
        }
    }
}
