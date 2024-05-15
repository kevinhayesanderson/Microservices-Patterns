using AspnetRun.Web.ViewModels;
using System.Threading.Tasks;

namespace AspnetRun.Web.Interfaces
{
    public interface IWishlistPageService
    {
        Task<WishlistViewModel> GetWishlist(string userName);

        Task RemoveItem(int wishlistId, int productId);

        Task AddToCart(string userName, int productId);
    }
}