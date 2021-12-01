using CleanArch.Application.Dtos;
using CleanArch.Application.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Mvc.Controllers
{
    public class BookController : Controller
    {
        private IBookServices _bookServices;

        public BookController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

        public IActionResult Index()
        {
            var model = _bookServices.GetAll();
            return View(model);
        }

        public IActionResult Get(int id)
        {
            var model = _bookServices.Get(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddBookDto dto)
        {
            if (ModelState.IsValid)
            {
                _bookServices.AddBook(dto);
                return RedirectToAction("Index", "Books");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _bookServices.Get(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(int id, EditBookDto dto)
        {
            if (ModelState.IsValid)
            {
                _bookServices.Edit(id, dto);
                return RedirectToAction("Index", "Books");
            }
            else
                return View(dto);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _bookServices.Get(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult DeleteBook(int id)
        {
            _bookServices.Delete(id);
            return RedirectToAction("Index", "Books");
        }
    }
}
