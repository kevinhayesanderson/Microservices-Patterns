using AspnetRun.Core.Entities;
using AspnetRun.Core.Repositories;
using AspnetRun.Core.Specifications;
using AspnetRun.Infrastructure.Data;
using AspnetRun.Infrastructure.Repository.Base;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetRun.Infrastructure.Repository
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        public CartRepository(AspnetRunContext dbContext) : base(dbContext)
        {
        }

        public async Task<Cart> GetByUserNameAsync(string userName)
        {
            var spec = new CartWithItemsSpecification(userName);
            return (await GetAsync(spec)).FirstOrDefault();
        }
    }
}