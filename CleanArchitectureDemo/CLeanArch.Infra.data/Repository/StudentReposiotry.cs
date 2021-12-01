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
    public class StudentReposiotry : IStudentRepository
    {
        private LibraryDbContext _ldc;

        public StudentReposiotry(LibraryDbContext ldc)
        {
            _ldc = ldc;
        }

        public void AddStudent(Student student)
        {
            _ldc.Students.Add(student);
        }

        public void Delete(int id)
        {
            var student = _ldc.Students.Find(id);
            _ldc.Students.Remove(student);
        }

        public void Edit(Student student)
        {
            _ldc.Students.Update(student);
        }

        public Student Get(int id)
        {
            return _ldc.Students.Single(p => p.Id == id);
        }

        public ICollection<Student> GetAll()
        {
            return _ldc.Students.ToList();
        }

        public void Save()
        {
            _ldc.SaveChanges();
        }
    }
}
