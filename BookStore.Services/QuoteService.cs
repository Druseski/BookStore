using BookStore.Entities.Quotes;
using BookStore.Repositories.Interfaces;
using BookStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Services
{
    public class QuoteService : IQuoteService
    {

        private readonly IQuoteRepository _quoteRepository;

        public QuoteService(IQuoteRepository quoteRepository)
        {
            _quoteRepository = quoteRepository;
        }

        public void Add(QuoteMap quote)
        {
            _quoteRepository.AddQuote(quote);
        }
    }



}
