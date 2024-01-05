using System.ComponentModel.DataAnnotations;

namespace LoanManagement.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set;}
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set;}
        public int UpdatedBy { get; set; }
    }
}
