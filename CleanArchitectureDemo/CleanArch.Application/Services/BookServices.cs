using CleanArch.Application.Dtos;
using CleanArch.Application.Interface;
using CleanArch.Domain.Models;
using CleanArch.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class BookServices : IBookServices
    {
        public IBookRepository _bookRepository;

        public BookServices(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddBook(AddBookDto dto)
        {
            var book = Books.Create(dto.Id, dto.Name, dto.Isbn, dto.AuthorName);
            _bookRepository.AddBook(book);
            _bookRepository.Save();
        }

        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }

        public void Edit(int id, EditBookDto dto)
        {
            var book = _bookRepository.Get(id);
            book.Edit(dto.Name, dto.Isbn, dto.AuthorName);
            _bookRepository.Edit(book);
            _bookRepository.Save();
        }

        public BookDto Get(int id)
        {
            return new BookDto()
            {
                Book = _bookRepository.Get(id)
            };
        }

        public BooksDto GetAll()
        {
            return new BooksDto()
            {
                Books = _bookRepository.GetAll()
            };
        }
    }
}
