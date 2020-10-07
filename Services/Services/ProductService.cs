using Repositories.Models;
using Repositories.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //public IEnumerable<DimProduct> GetMySpecialProduct()
        //{
        //    return _productRepository.MyProductSpecificMethod();
        //}

        public async Task<IEnumerable<SpGetProductById>> GetProductById()
        {
            return await _productRepository.GetProductById();
        }
    }
}