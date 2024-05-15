using AspnetRun.Web.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspnetRun.Web.Interfaces
{
    public interface ICategoryPageService
    {
        Task<IEnumerable<CategoryViewModel>> GetCategories();
    }
}