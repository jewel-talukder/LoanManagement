namespace LoanManagement.Models
{
    public class PermanentAddress
    {
        public int Id { get; set; }
        public string Village { get; set; }
        public string PostOffice { get; set; }
        public string SubDistrict { get; set; }
        public string District { get; set; }
        public int ZipCode { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
