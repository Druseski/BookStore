using BookStore.Entities.Quotes;

namespace BookStore.Services.Interfaces
{
    public interface IQuoteService
    {
        void Add(QuoteMap quote);
    }
}
