using Auctions.Models;

namespace Auctions.Data.Services.Abstract
{
    public interface IBidService
    {
        Task Add(Bid bid);
        IQueryable<Bid> GetAll();

    }
}
