using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.RepositoryInterface
{
    public interface IBookRepository
    {
        Books Get(int id);
        ICollection<Books> GetAll();
        void Edit(Books book);
        void AddBook(Books book);
        void Delete(int id);
        void Save();
    }
}
