using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entitites.Models;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class BookRepository : RepositroyBase<BookModel>, IBookRepositories
    {
        public BookRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneBook(BookModel book)=>Create(book);

        public void DeleteOneBook(BookModel book)=>Delete(book);
        public IQueryable<BookModel> GetAllBook(bool isTrack)=>findAll(isTrack).OrderBy(b=>b.bookId);

        public IQueryable<BookModel> GetOneBook(int id, bool isTrack)=>
            findByCondition(b=>b.bookId.Equals(id),isTrack);

        public void UpdateOneBook(BookModel book)=>Update(book);
    }
}