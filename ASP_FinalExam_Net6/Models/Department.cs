using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace ASP_FinalExam_Net6.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Min(0)]
        public int EmployeeCount { get; set; }

        public ICollection<Employee>? Employees { get; set; }
    }
}
