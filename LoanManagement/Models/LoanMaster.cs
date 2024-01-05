using System.ComponentModel.DataAnnotations;

namespace LoanManagement.Models
{
    public class LoanMaster
    {
        [Key]
        public int LoanMasterId { get; set; }
        public int CustomerId { get; set; }
        public double LoanAmount { get; set; }
        public double InterestRate { get; set; } = 3;
        public double PaidAmount { get; set; }
        public double DailyInstallment { get; set; }
        public int InstallmentPeriod { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime LoanDueDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set;}
        public int UpdatedBy { get; set; }
    }
}
