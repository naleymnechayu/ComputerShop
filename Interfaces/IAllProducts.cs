using ComputerShop.Models;

namespace ComputerShop.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Products> Products { get;}
        IEnumerable<Products> GetFavouriteProduct {  get; set; }
        Products GetObjectProduct(int id);
    }
}
