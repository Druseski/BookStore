using BookStore.Entities.Quotes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repositories.Interfaces
{
    public interface IQuoteRepository
    {
        void AddQuote(QuoteMap quote);
    }
}
