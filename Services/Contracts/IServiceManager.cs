using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IServiceManager
    {
        IBookService bookService{get;}
        
    }
}