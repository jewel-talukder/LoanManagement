using System.ComponentModel.DataAnnotations;

namespace LoanManagement.Models
{
    public class SavingMaster
    {
        [Key]
        public int SavingMasterId { get; set; }
        public int CustomerId { get; set; }
        public double InterestRate { get; set; } = 1.5;
        public double OpeningBalance { get; set; } = 10;
        public int MinBalance { get; set; } = 10;
        public double TotalBalance { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
