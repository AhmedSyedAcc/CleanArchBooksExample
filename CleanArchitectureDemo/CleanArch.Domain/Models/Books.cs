using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Models
{
    public class Books
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Isbn { get; protected set; }
        public string AuthorName { get; protected set; }

        protected Books()
        {

        }

        protected Books(int id, string name, string isbn, string authorName)
        {
            Id = id;
            Name = name;
            Isbn = isbn;
            AuthorName = authorName;
        }

        public static Books Create(int id, string name, string isbn, string authorName)
        {
            return new Books(id, name, isbn, authorName);
        }
    }
}
