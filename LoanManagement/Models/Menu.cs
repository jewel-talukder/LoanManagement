namespace LoanManagement.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public int ParentMenu { get; set; }
        public string MenuUrl { get; set; }
        public string MenuIcon { get; set; }
        public int MenuSerial { get; set; }
        public int MenuStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

    }
}
