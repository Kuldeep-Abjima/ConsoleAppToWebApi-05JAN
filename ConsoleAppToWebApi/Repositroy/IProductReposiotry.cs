using ConsoleAppToWebApi.Models;

namespace ConsoleAppToWebApi.Repository
{
    public interface IProductReposiotry
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();

        string GetName();
    }
}