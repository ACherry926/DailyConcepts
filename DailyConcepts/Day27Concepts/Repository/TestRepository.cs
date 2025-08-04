using Day27Concepts.Model;
using System.Collections.Generic;

namespace Day27Concepts.Repository
{
    public class TestRepository : IProductsRepository
    {
        public int AddProduct(ProductModel product)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public string GetName()
        {
            return "Name from TestRepository";
        }
    }
}
