using Ef.Models.Entities;
using Ef.Models.Repositories.Interfaces;

namespace Ef.Models.Repositories.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        public static List<Student> ListOfStuents = new List<Student>
        {
           new Student {Id = 1, FirstName = "Mile", LastName = "Montego", MatricNumber = "ICT/122150187", Department = "Statistics", Gender = "Male", School = "ICT", Age = 17},
           new Student {Id = 2, FirstName = "Vanessa", LastName = "Lyon", MatricNumber = "ENG/211230189", Department = "Mechanical Engineer", Gender = "Female", School = "Engineer", Age = 18},
           new Student {Id = 3, FirstName = "Kim", LastName = "Jojo", MatricNumber = "BIS/422470128", Department = "Business Admin", Gender = "Female", School = "Business Study", Age = 19},
           new Student {Id = 4, FirstName = "Michael", LastName = "Brown", MatricNumber = "ART/522150187", Department = "Law", Gender = "Male", School = "Art", Age = 20},
        };
        public Student CreateStudent(Student student)
        {
            ListOfStuents.Add(student);
            return student;
        }

        public bool DeleteStudent(int id)
        {
            var student = GetStudent(id);
            return ListOfStuents.Remove(student);
        }

        public List<Student> GetAllStudent()
        {
            return ListOfStuents;
        }

        public Student GetStudent(int id)
        {
            var student = ListOfStuents
            .Where(s => s.Id == id)
            .SingleOrDefault();
            return student;
        }

        public Student UpdateStudent(Student student)
        {
            var stud = GetStudent(student.Id);
            stud.FirstName = student.FirstName;
            stud.LastName = student.LastName;
            stud.MatricNumber = student.MatricNumber;
            stud.Department = student.Department;
            stud.Gender = student.Gender;
            stud.Age = student.Age;
            return stud;
        }
    }
}