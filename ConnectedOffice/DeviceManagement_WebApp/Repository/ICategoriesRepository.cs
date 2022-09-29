using DeviceManagement_WebApp.Models;
using System;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public interface ICategoriesRepository : IGenericRepository<Category>
    {
        bool CategoryExists(Guid id); //25903098 References the method created if a category exists in the Category repository
        Task<Category> AssignCategory(Guid? id); //25903098 References the method created assign a category in the Category repository
        void UpdateType(Category category); //25903098 References the custom update method in the Category repository
    }
}
