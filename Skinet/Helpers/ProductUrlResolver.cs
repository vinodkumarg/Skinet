using AutoMapper;
using Microsoft.Extensions.Configuration;
using Skinet.Dtos;
using Skinet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skinet.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>
    {
        private readonly IConfiguration _configuration;

        public ProductUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Resolve(Product source, ProductToReturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrWhiteSpace(source.ImageUrl))
            {
                return _configuration["ApiUrl"] + source.ImageUrl;
            }
            return null;
        }
    }
}
