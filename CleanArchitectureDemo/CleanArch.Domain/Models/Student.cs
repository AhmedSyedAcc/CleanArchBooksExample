using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ICollection<Books> Books { get; set; }

        protected Student()
        {

        }

        public Student(int id, string name, int age, ICollection<Books> books)
        {
            Id = id;
            Name = name;
            Age = age;
            Books = books;
        }

        public static Student Create(int id, string name, int age, ICollection<Books> books)
        {
            return new Student(id, name, age, books);
        }
        public void Edit(string name, int age, ICollection<Books> books)
        {
            this.Name = name;
            this.Age = age;
            this.Books = books;
        }
    }
} 
