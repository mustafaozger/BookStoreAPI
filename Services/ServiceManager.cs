using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IBookService> _bookService; 
        public ServiceManager(IRepositoryManager manager){
            _bookService=new Lazy<IBookService>(()=>new BookService(manager));
        }
        public IBookService bookService => _bookService.Value; 
    }
}