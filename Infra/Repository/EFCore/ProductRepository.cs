using Entities;
using Infra.IRepository.EFCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository.EFCore
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }
    }
}
