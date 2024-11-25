using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entitites.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class BookService : IBookService
    {
        private readonly IRepositoryManager _manager;

        public BookService(IRepositoryManager manager){
            _manager=manager;
        }


        public BookModel CreateOneBook(BookModel book)
        {
            _manager.Book().CreateOneBook(book);
            _manager.Save();
            return book;
        }


        public void DeleteOneBook(int id, bool trackChange)
        {
            var book=_manager.Book().GetOneBook(id,trackChange).SingleOrDefault();
            _manager.Book().DeleteOneBook(book);
            _manager.Save();
        }

        public IEnumerable<BookModel> GetAllBook(bool trackChange)
        {
            return _manager.Book().GetAllBook(trackChange);
        }

        public BookModel GetOneBook(int id, bool trackChange)
        {
            return _manager.Book().GetOneBook(id,trackChange).SingleOrDefault();
        }

        public void UpdateOneBook(int id, bool trackChange)
        {
            var book=_manager.Book().GetOneBook(id,trackChange).SingleOrDefault();
            _manager.Book().UpdateOneBook(book);
            _manager.Save();            
        }
    }
}