using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entitites.Models;

namespace Services.Contracts
{
    public interface IBookService
    {
        public IEnumerable<BookModel> GetAllBook(bool trackChange);
        public BookModel GetOneBook(int id , bool trackChange);
        public BookModel CreateOneBook(BookModel book);
        public bool UpdateOneBook(int id,bool trackChange);
        public bool DeleteOneBook(int id , bool trackChange);
    }
}