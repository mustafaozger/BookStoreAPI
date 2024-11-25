using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<IBookRepositories> bookRepositories;
        public RepositoryManager(RepositoryContext context)
        {
            _context=context;
            bookRepositories=new Lazy<IBookRepositories>(()=>new BookRepository(_context));
        }

        public IBookRepositories Book()=>bookRepositories.Value;

        public void Save()=>_context.SaveChanges();
    }
}