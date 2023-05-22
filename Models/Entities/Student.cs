using System.ComponentModel.DataAnnotations;

namespace Ef.Models.Entities
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide first name")]
        [MinLength(5, ErrorMessage ="First name must have more than 5 characters")]
        public string FirstName { get; set; }

        [Required]
         [MaxLength(10, ErrorMessage ="Last name must not have more than 10 characters")]
        public string LastName { get; set; }
        

        [Required]
        public string MatricNumber { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [Compare("Department")]
        public string School { get; set; }

        [Required]
        [Range(18,40)]
        public int Age { get; set; }
    }
}