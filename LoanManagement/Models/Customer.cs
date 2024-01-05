using System.ComponentModel.DataAnnotations;

namespace LoanManagement.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNid { get; set; }
        public string Gender { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone1 { get; set; }
        public string CustomerPhone2 { get; set; }
        public string CustomerPassion { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerFatherName { get; set; }
        public string CustomerMotherName { get; set; }
        public int CustomerAge { get; set; }
        public string CustomerProfilePicture { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }



    }
}
