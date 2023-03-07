using BlazzorFullStack.Shared;

namespace BlazzorFullStack.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<Service<List<Category>>> GetCategories();
    }
}
