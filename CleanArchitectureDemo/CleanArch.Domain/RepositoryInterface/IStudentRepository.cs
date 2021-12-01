using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.RepositoryInterface
{
    public interface IStudentRepository
    {
        Student Get(int id);
        ICollection<Student> GetAll();
        void Edit(Student student);
        void AddStudent(Student student);
        void Delete(int id);
        void Save();
    }
}
