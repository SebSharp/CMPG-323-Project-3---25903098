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
            return _context.Category.Any(e => e.CategoryId == id); //25903098 We use this to set the conext for any one category to see if it exists
        }

        public async Task<Category> AssignCategory(Guid? id)
        {
            var category = await _context.Category.FirstOrDefaultAsync(m => m.CategoryId == id); //25903098 We use this to set the context asynchronously via a Task 
            return category;
        }
        public void UpdateType(Category category) //25903098 Custom Update method for Categories only
        {
            _context.Update(category);
        }

    }
}
