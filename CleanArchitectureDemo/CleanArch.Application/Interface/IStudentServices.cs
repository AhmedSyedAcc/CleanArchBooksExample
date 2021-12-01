using CleanArch.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interface
{
    public interface IStudentServices
    {
        StudentDto Get(int id);
        StudentsDto GetAll();
        void Edit(int id, EditStudentDto dto);
        void AddStudent(AddStudentDto dto);
        void Delete(int id);
    }
}
