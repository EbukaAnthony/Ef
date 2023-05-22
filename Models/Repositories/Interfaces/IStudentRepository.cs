using Ef.Models.Entities;

namespace Ef.Models.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        public Student CreateStudent(Student student);
        public Student UpdateStudent(Student student);
        public Student GetStudent(int id);
        public List<Student> GetAllStudent();
        public bool DeleteStudent(int id);
         
    }
}