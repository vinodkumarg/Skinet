using Skinet.DataAccess.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skinet.DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Product = new ProductRepository(dbContext);
            ProductBrand = new ProductBrandRepository(dbContext);
            ProductType = new ProductTypeRepository(dbContext);
        }
        public IProductRepository Product { get; private set; }

        public IProductBrandRepository ProductBrand { get; private set; }

        public IProductTypeRepository ProductType { get; private set; }

        public void Dispose()
        {
            _dbContext.DisposeAsync();
        }

        public void SaveAsync()
        {
            _dbContext.SaveChangesAsync();
        }
    }
}
