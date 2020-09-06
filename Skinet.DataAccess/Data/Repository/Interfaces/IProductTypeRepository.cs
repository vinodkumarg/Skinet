using Skinet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skinet.DataAccess.Data.Repository.Interfaces
{
    public interface IProductTypeRepository:IRepository<ProductType>
    {
        void Update(ProductType productType);
    }
}
