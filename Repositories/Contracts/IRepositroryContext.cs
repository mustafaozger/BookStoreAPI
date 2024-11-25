using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositroryContext<T>
    {
        //CRUD 
        IQueryable<T> findAll(bool trackChange);
        IQueryable<T> findByCondition(Expression<Func<T,bool>> expression,
            bool trackChange);
        void Create(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
    }
}