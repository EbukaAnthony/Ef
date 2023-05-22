using Ef.Models.Entities;
using Ef.Models.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ef.Controllers
{
    public class BooksController:Controller
    {
        public readonly IStudentService _studentService;
        public BooksController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var student = _studentService.GetAllStudents().ToList();
            return View(student);
        }

        [HttpGet]
        public IActionResult GetStudent(int id)
        {
            var student = _studentService.GetStudentById(id);
            return View(student);
        }


        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            var newStudent = _studentService.Create(student);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            var student = _studentService.GetStudentById(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student student)
        {
            _studentService.Update(student);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            var student = _studentService.DeleteStudent(id);
            return RedirectToAction("Index");
        }
        [HttpPost, ActionName("DeleteStudent")]
        public IActionResult ConfirmDeleteStudent(int id)
        {
            var student = _studentService.DeleteStudent(id);
            return RedirectToAction("Index");
        }
    }
}