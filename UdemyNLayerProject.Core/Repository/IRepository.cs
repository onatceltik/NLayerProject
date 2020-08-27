using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UdemyNLayerProject.Core.Repository
{
    interface IRepository<T> where T : class // specifies that this entity T must be a class
    {
        Task<T> GetByIdAsync(int Id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);

        //for exp: category.SingleOrDefaultAsync(x => x.Name = "Books")
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);

        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);

        T Update(T entity);
    }
}
