using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Base
{
    public class EntityBaseRepository<TOutput, TInput> : IEntityBaseRepository<TOutput, TInput> where TOutput : class, new()
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public EntityBaseRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;  
        }

        public async Task<TOutput> AddAsync(TInput entity)
        {
            TOutput data = _mapper.Map<TOutput>(entity);
            await _context.Set<TOutput>().AddAsync(data);
            await _context.SaveChangesAsync();  
            return data;
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TOutput>> GetAllAsync() => await _context.Set<TOutput>().ToListAsync();

        public async Task<IEnumerable<TOutput>> GetAllAsync(params Expression<Func<TOutput, object>>[] includeProperties)
        {
            /*IQueryable<TOutput> query = _context.Set<TOutput>();
            query = includeProperties.Aggregate(query, (current, includeProperties) => current.Include(includeProperties));
            return await query.ToListAsync();*/
            IQueryable<TOutput> query = _context.Set<TOutput>();
            query = includeProperties.Aggregate(query, (current, includeProperties) => current.Include(includeProperties));
            return await query.ToListAsync();
        }

        public Task<IEnumerable<TOutput>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TOutput> UpdateAsync(int id, TInput entity)
        {
            throw new NotImplementedException();
        }
    }
}
