using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyNLayerProject.Core.Models;

namespace UdemyNLayerProject.Data.Seeds
{
    class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;

        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
                (
                    new Product
                    {
                        Id = 1,
                        Name = "TestProductCategory0",
                        Price = 12.50m,
                        Stock = 999, CategoryId = _ids[0] }
                    ,                    
                    new Product
                    {
                        Id = 2,
                        Name = "TestProductCategory1",
                        Price = 9.99m,
                        Stock = 100,
                        CategoryId = _ids[1]
                    }
                );
        }
    }
}
