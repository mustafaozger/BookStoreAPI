using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entitites.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class BookManager : IBookService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;

        public BookManager(IRepositoryManager manager,ILoggerService logger){
            _manager=manager;
            _logger=logger;
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
            if(book is null){
                _logger.LogWarning($"The Book with id {id} could not found");
                throw new Exception($"The Book with id {id} could not found");
            }
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
             if(book is null){
                _logger.LogWarning($"The Book with id {id} could not found");
                throw new Exception($"The Book with id {id} could not found");
            }
            _manager.Book().UpdateOneBook(book);
            _manager.Save();            
        }
    }
}