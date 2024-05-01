using Auctions.Data.Services.Abstract;
using Auctions.Models;

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
    }
}
