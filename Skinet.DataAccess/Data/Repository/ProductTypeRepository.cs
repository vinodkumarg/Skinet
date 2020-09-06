using Skinet.DataAccess.Data.Repository.Interfaces;
using Skinet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skinet.DataAccess.Data.Repository
{
    public class ProductTypeRepository : Repository<ProductType>, IProductTypeRepository 
    {
        public ProductTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public void Update(ProductType productType)
        {
            throw new NotImplementedException();
        }
    }
}
