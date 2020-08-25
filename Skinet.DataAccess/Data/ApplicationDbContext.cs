using Microsoft.EntityFrameworkCore;
using Skinet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skinet.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){} //for passing connection string.
        public DbSet<Product> Products { get; set; }
    }
}
