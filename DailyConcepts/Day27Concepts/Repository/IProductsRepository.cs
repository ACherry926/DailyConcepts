using Day27Concepts.Model;
using System.Collections.Generic;

namespace Day27Concepts.Repository
{
    public interface IProductsRepository
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();

        string GetName();
    }
}