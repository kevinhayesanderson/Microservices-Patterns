using AspnetRun.Core.Entities;
using AspnetRun.Core.Repositories.Base;
using System.Threading.Tasks;

namespace AspnetRun.Core.Repositories
{
    public interface IWishlistRepository : IRepository<Wishlist>
    {
        Task<Wishlist> GetByUserNameAsync(string userName);
    }
}