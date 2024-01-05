namespace LoanManagement.Models
{
    public class UserList
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public int DesignationId { get; set; }
        public int DepartmentId { get; set; }
        public int CompanyId { get; set; }
        public string UserPassword { get; set; }
        public string UserAddress { get; set; }
        public string UserGender { get; set; }
        public string UserBloodGroup { get; set; }
        public string UserNID { get; set; }
        public string UserPassport { get; set; }
        public string UserDrivingLicense { get; set; }
        public string UserPhoto { get; set; }
        public string UserSignature { get; set; }
        public string UserStatus { get; set; }
        public string UserJoiningDate { get; set; }
        public string UserResignDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
