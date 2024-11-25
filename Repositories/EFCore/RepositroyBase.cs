using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class RepositroyBase<T> : IRepositroryContext<T> 
        where T:class
    {
        protected readonly RepositoryContext _context;
        public RepositroyBase(RepositoryContext context)
        {
            _context=context;
        }
        public void Create(T entitiy)=>_context.Set<T>().Add(entitiy);

        public void Delete(T entitiy) => _context.Set<T>().Remove(entitiy);

        public IQueryable<T> findAll(bool trackChange)=>
            !trackChange ? _context.Set<T>().AsNoTracking() : _context.Set<T>(); 

        public IQueryable<T> findByCondition(Expression<Func<T, bool>> expression, bool trackChange) =>
            !trackChange ? _context.Set<T>().Where(expression).AsNoTracking() : 
                           _context.Set<T>().Where(expression); 

        public void Update(T entitiy)=>_context.Set<T>().Update(entitiy);
    }
}