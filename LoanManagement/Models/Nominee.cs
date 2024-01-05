using System.ComponentModel.DataAnnotations;

namespace LoanManagement.Models
{
    public class Nominee
    {
        [Key]
        public int NomineeId { get; set; }
        public string NomineeName { get; set; }
        public string NomineeRelation { get; set; }
    public string NomineeAddress { get; set; }    
        public string NomineeContact { get; set; }
        public string NomineeEmail { get; set; }
        public string NomineeNID { get; set; }
        public string NomineePhoto { get; set; }
        public string NomineeSignature { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set;}
        public int UpdatedBy { get; set; }
    }
}
