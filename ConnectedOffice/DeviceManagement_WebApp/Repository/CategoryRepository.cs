using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoriesRepository
    {
        public CategoryRepository(ConnectedOfficeContext context) : base(context)
        {
        }

    }
}
