using ConsoleAppToWebApi.Models;
using ConsoleAppToWebApi.Repository;

namespace ConsoleAppToWebApi.Repositroy
{
    public class TestRepository : IProductReposiotry
    {
        public int AddProduct(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return "Name from TestRep";
        }
    }
}
