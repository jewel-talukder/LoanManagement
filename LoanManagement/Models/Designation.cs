using System.ComponentModel.DataAnnotations;

namespace LoanManagement.Models
{
    public class Designation
    {
        [Key]
        public int DesignationId { get; set; }
        public string? DesignationName { get; set; }
        public string? DesignationDescription { get; set; }
        public int DepartmentId { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set;}
        public int UpdatedBy { get; set; }
    }
}
