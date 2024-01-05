using System.ComponentModel.DataAnnotations;

namespace LoanManagement.Models
{
    public class SavingDetails
    {
        [Key]
        public int SavingDetailsId { get; set; }
        public int SavingMasterId { get; set; }
        public double DepositAmount { get; set; }
        public DateTime DepositDate { get; set; }                                   
        public DateTime CreatedAt { get; set; }             
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set;}
        public int UpdatedBy { get; set; }
    }
}
