using DeviceManagement_WebApp.Models;
using System;

namespace DeviceManagement_WebApp.Repository
{
    public interface ICategoriesRepository : IGenericRepository<Category>
    {
        bool CategoryExists(Guid id);
        Category AssignCategory(Guid? id);
        void UpdateType(Category category);
    }
}
