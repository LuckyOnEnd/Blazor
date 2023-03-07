using BlazzorFullStack.Shared;

namespace BlazzorFullStack.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task GetCategories();
    }
}
