using CleanArch.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interface
{
    public interface IBookServices
    {
        BookDto Get(int id);
        BooksDto GetAll();
        void Edit(int id, EditBookDto dto);
        void AddBook(AddBookDto dto);
        void Delete(int id);
    }
}
