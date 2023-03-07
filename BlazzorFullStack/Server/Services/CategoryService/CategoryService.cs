using BlazzorFullStack.Server.Data;
using BlazzorFullStack.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazzorFullStack.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _db;
        public CategoryService(ApplicationDbContext db) 
        {
            _db = db;
        }

        public async Task<Service<List<Category>>> GetCategories()
        {
            var result = await _db.Categories.ToListAsync();
            return new Service<List<Category>> { Data = result };
        }
    }
}
