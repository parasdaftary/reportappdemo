using Repositories.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Services
{
    public interface IProductService
    {
       // IEnumerable<DimProduct> GetMySpecialProduct();

        Task<IEnumerable<SpGetProductById>> GetProductById();
    }
}