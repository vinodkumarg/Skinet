using Skinet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skinet.DataAccess.Data.Repository.Interfaces
{
    public interface IProductBrandRepository : IRepository<ProductBrand>
    {
        void Update(ProductBrand productBrand);
    }
}
