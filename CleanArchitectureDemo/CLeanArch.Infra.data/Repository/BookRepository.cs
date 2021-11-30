using CleanArch.Domain.Models;
using CleanArch.Domain.RepositoryInterface;
using CLeanArch.Infra.data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLeanArch.Infra.data.Repository
{
    public class BookRepository : IBookRepository
    {
        public LibraryDbContext _ldc;

        public BookRepository(LibraryDbContext ldc)
        {
            _ldc = ldc;
        }

        public void AddBook(Books book)
        {
            _ldc.Books.Add(book);
        }

        public void Delete(int id)
        {
            Books book = _ldc.Books.Find(id);
            _ldc.Books.Remove(book);
        }

        public void Edit(Books book)
        {
            _ldc.Books.Update(book);
        }

        public Books Get(int id)
        {
            return _ldc.Books.Single(p => p.Id == id);
        }

        public ICollection<Books> GetAll()
        {
            return _ldc.Books.ToList();
        }

        public void Save()
        {
            _ldc.SaveChanges();
        }
    }
}
