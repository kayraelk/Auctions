using Auctions.Data.Services.Abstract;
using Auctions.Models;
using Microsoft.EntityFrameworkCore;

namespace Auctions.Data.Services.Concrete
{
    public class BidService: IBidService
    {
        private readonly ApplicationDbContext _context;
        public BidService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Bid bid)
        {
            _context.Bids.Add(bid);
            await _context.SaveChangesAsync(); //Neden save changes kullanıldı?
        }

        public IQueryable<Bid> GetAll()
        {
            var applicationDbContext = from a in _context.Bids.Include(l => l.Listing).ThenInclude(l => l.User)
                                       select a;
            return applicationDbContext;
        }
    }
}
