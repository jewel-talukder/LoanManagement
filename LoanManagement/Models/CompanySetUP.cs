using System.ComponentModel.DataAnnotations;

namespace LoanManagement.Models
{
    public class CompanySetUP
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int ParentCompany { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone1 { get; set; }
        public string CompanyPhone2 { get; set; }
        public string CompanyEmail { get; set; }
        public string FacebookUrl { get; set; }




    }
}
