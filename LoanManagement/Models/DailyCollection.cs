namespace LoanManagement.Models
{
    public class DailyCollection
    {
        public int DailyCollectionId { get; set; }
        public int LoanMasterId { get; set; }
        public double CollectionAmount { get; set; }
        public DateTime CollectionDate { get; set; }
        public string Description { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set;}
        public int UpdatedBy { get; set; }
    }
}
