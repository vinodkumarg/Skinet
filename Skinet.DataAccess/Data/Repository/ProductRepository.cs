using Skinet.Models;
using Skinet.DataAccess.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skinet.DataAccess.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public void Update(Product product)
        {
        }
    }
}
