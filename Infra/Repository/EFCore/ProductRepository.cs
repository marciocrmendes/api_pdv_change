using Entities;
using Infra.Interfaces.IRepository.EFCore;
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
