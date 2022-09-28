using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Repository;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoriesRepository
    {
        public CategoryRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public bool CategoryExists(Guid id)
        {
            return _context.Category.Any(e => e.CategoryId == id);
        }

        public Category AssignCategory(Guid? id)
        {
            var category = _context.Category.FirstOrDefaultAsync(m => m.CategoryId == id);
            return category;
        }
        public void UpdateType(Category category)
        {
            _context.Update(category);
        }

    }
}
