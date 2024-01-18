using LoanManagement.Models;

namespace LoanManagement.Interfaces
{
    public interface IRole
    {
        Task<List<Role>> GetRoleListAsync();
        Task<bool> CreateOrUpdate(Role role, int userId);
    }
}
