using Auctions.Models;

namespace Auctions.Data.Services.Abstract
{
    public interface ICommentService
    {
        Task Add(Comment comment);
    }
}
