using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Skinet.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Skinet.DataAccess.Data
{
    public class ApplicationContextSeed
    {
		[Obsolete]
		public static async Task SeedAsync(ApplicationDbContext dbContext, ILoggerFactory loggerFactory)
        {
			try
			{
				using var transaction = dbContext.Database.BeginTransaction();
				if (!dbContext.ProductBrands.Any())
				{
					dbContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[ProductBrands] ON");

					var brandsData = File.ReadAllText("../Skinet.DataAccess/Data/SeedData/brands.json");
					var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
					await dbContext.ProductBrands.AddRangeAsync(brands);
					await dbContext.SaveChangesAsync();

					dbContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[ProductBrands] OFF");

				}
				if (!dbContext.ProductTypes.Any())
				{
					dbContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[ProductTypes] ON");

					var typesData = File.ReadAllText("../Skinet.DataAccess/Data/SeedData/types.json");
					var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);
					await dbContext.ProductTypes.AddRangeAsync(types);
					await dbContext.SaveChangesAsync();

					dbContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[ProductTypes] OFF");
				}
				if (!dbContext.Products.Any())
				{

					var productsData = File.ReadAllText("../Skinet.DataAccess/Data/SeedData/products.json");
					var products = JsonSerializer.Deserialize<List<Product>>(productsData);
					await dbContext.Products.AddRangeAsync(products);
					await dbContext.SaveChangesAsync();

				}

				transaction.Commit();

			}
			catch (Exception ex)
			{
				var logger = loggerFactory.CreateLogger<ApplicationContextSeed>();
				logger.LogError(ex.Message);
			}
        }
    }
}
