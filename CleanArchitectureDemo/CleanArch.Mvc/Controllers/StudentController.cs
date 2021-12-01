using CleanArch.Application.Dtos;
using CleanArch.Application.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Mvc.Controllers
{
    public class StudentController : Controller
    {
        private IStudentServices _studentServices;

        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        public IActionResult Index()
        {
            var student = _studentServices.GetAll();
            return View(student);
        }
        public IActionResult Get(int id)
        {
            var student = _studentServices.Get(id);
            return View(student);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddStudentDto dto)
        {
            if (ModelState.IsValid)
            {
                _studentServices.AddStudent(dto);
                return RedirectToAction("Index", "Student");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _studentServices.Get(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(int id, EditStudentDto dto)
        {
            if (ModelState.IsValid)
            {
                _studentServices.Edit(id, dto);
                return RedirectToAction("Index", "Student");
            }
            else
                return View(dto);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _studentServices.Get(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult DeleteStudent(int id)
        {
            _studentServices.Delete(id);
            return RedirectToAction("Index", "Books");
        }
    }
}
