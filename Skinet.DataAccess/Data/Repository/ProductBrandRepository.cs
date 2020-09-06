using Skinet.DataAccess.Data.Repository.Interfaces;
using Skinet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skinet.DataAccess.Data.Repository
{
    public class ProductBrandRepository : Repository<ProductBrand>, IProductBrandRepository 
    {
        public ProductBrandRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public void Update(ProductBrand productBrand)
        {
            throw new NotImplementedException();
        }
    }
}
