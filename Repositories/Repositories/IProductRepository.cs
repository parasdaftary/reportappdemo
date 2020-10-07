using Repositories.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public interface IProductRepository : IRepository<SpGetProductById>
    {
        //IEnumerable<SpGetProductById> MyProductSpecificMethod();

        new Task<IEnumerable<SpGetProductById>> GetProductById();
    }
}