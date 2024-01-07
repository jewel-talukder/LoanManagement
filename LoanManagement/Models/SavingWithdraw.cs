namespace LoanManagement.Models
{
    public class SavingWithdraw
    {
        public int SavingWithdrawId { get; set; }
        public int SavingMasterId { get; set; }
        public double WithdrawAmount { get; set; }
        public DateTime WithdrawDate { get; set; }
        public string Description { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set;}
        public int UpdatedBy { get; set; }
    }
}
