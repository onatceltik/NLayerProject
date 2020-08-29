using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProject.Core.Repository;
using UdemyNLayerProject.Core.UnitOfWork;
using UdemyNLayerProject.Data.Repositories;

namespace UdemyNLayerProject.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;

        // ?? means if there is no repo create a new one
        public IProductRepository Products => _productRepository
            = _productRepository ?? new ProductRepository(_context);

        public ICategoryRepository Categories => _categoryRepository
            = _categoryRepository ?? new CategoryRepository(_context);
        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        // Commit or SaveChanges
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
