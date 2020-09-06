using System;
using System.Collections.Generic;
using System.Text;

namespace Skinet.DataAccess.Data.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Product { get; }
        IProductBrandRepository ProductBrand { get; }
        IProductTypeRepository ProductType { get; }
        void SaveAsync();
    }
}
