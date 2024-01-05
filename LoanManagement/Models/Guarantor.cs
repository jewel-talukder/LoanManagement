using System.ComponentModel.DataAnnotations;

namespace LoanManagement.Models
{
    public class Guarantor
    {
        [Key]
        public int GuarantorId { get; set; }
        public string GuarantorName { get; set; }
        public string GuarantorRelation { get; set; }
        public string GuarantorAddress { get; set; }
        public string GuarantorContact { get; set; }
        public string GuarantorEmail { get; set; }
        public string GuarantorNID { get; set; }
        public string GuarantorPhoto { get; set; }
        public string GuarantorSignature { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set;}
        public int UpdatedBy { get; set; }
    }
}
