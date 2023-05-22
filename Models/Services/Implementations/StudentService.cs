using Ef.Models.Entities;
using Ef.Models.Repositories.Interfaces;
using Ef.Models.Services.Interfaces;

namespace Ef.Models.Services.Implementations
{
    public class StudentService : IStudentService
    {
        public readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public Student Create(Student student)
        {
           var newStudent = _studentRepository.CreateStudent(student);
            return newStudent;
        }

        public bool DeleteStudent(int id)
        {
            var student = _studentRepository.DeleteStudent(id);
            return student;
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudent();
        }

        public Student GetStudentById(int id)
        {
            var student = _studentRepository.GetStudent(id);
            return student;
        }

        public Student Update(Student student)
        {
            var newStudent = _studentRepository.UpdateStudent(student);
            return newStudent;
        }
    }
}