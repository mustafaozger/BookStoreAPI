using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entitites.Models;

namespace Repositories.Contracts
{
    public interface IBookRepositories :IRepositroryContext<BookModel> 
    {
        public void CreateOneBook(BookModel book);
        public void DeleteOneBook(BookModel book);
        public void UpdateOneBook(BookModel book);
        IQueryable<BookModel> GetOneBook(int id, bool isTrack);
        IQueryable<BookModel> GetAllBook(bool isTrack);

    }
}