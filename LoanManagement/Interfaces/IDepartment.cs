using LoanManagement.Models;

namespace LoanManagement.Interfaces
{
    public interface IDepartment
    {
        Task<IEnumerable<dynamic>> GetDepartmentListAsync();
        Task<Department> GetDepartmentByIdAsync(int id);
        Task<bool> CreateOrUpdate(Department department, int flag);
        Task<Department> DeleteDepartmentAsync(int id);
    }
}
