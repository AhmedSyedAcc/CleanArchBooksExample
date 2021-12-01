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
    public class StudentServices : IStudentServices
    {
        private IStudentRepository _studentRepository;

        public StudentServices(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void AddStudent(AddStudentDto dto)
        {
            var student = Student.Create(dto.Id, dto.Name, dto.Age, dto.Books);
            _studentRepository.AddStudent(student);
            _studentRepository.Save();
        }

        public void Delete(int id)
        {
            _studentRepository.Delete(id);
        }

        public void Edit(int id, EditStudentDto dto)
        {
            var student = _studentRepository.Get(id);
            student.Edit(dto.Name, dto.Age, dto.Books);
            _studentRepository.Edit(student);
            _studentRepository.Save();
        }

        public StudentDto Get(int id)
        {
            return new StudentDto()
            {
                Student = _studentRepository.Get(id)
            };
        }

        public StudentsDto GetAll()
        {
            return new StudentsDto()
            {
                Students = _studentRepository.GetAll()
            };
        }
    }
}
