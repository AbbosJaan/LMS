using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Base
{
    public interface IEntityBaseRepository<TOutput, TInput> where TOutput : class, new()
    {
        Task<IEnumerable<TOutput>> GetAllAsync();
        Task<IEnumerable<TOutput>> GetAllAsync(params Expression<Func<TOutput, object>>[] includeProperties);
        Task<IEnumerable<TOutput>> GetByIdAsync(int id);
        Task<TOutput> AddAsync(TInput entity);
        Task<TOutput> UpdateAsync(int id, TInput entity);
        Task<bool> DeleteAsync(int id);
    }
}
