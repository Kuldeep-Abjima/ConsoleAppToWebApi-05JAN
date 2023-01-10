using ConsoleAppToWebApi.Models;

namespace ConsoleAppToWebApi.Repository

{
    public class ProductResposiotry : IProductReposiotry
    {
        private List<ProductModel> products = new List<ProductModel>();
        public int AddProduct(ProductModel product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return product.Id;

        }
        public List<ProductModel> GetAllProducts()
        {
            return products;
        }

        public string GetName()
        {
            return "Name of ProductRepo";
        }
    }
}
