using Ef.Models.Entities;

namespace Ef.Models.Services.Interfaces
{
    public interface IStudentService
    {
        public Student Create(Student student);
        public Student Update(Student student);
        public Student GetStudentById(int id);
        public List<Student> GetAllStudents();
        public bool DeleteStudent(int id);
    }
}