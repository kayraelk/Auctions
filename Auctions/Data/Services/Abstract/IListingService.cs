using Auctions.Models;

namespace Auctions.Data.Services.Abstract
{
    public interface IListingService
    {
        IQueryable<Listing> GetAll();
    }
}
