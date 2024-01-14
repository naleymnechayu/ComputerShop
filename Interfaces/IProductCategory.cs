using ComputerShop.Models;

namespace ComputerShop.Interfaces
{
    public interface IProductCategory
    {
        IEnumerable<Category> GetCategories { get; }
    }
}
