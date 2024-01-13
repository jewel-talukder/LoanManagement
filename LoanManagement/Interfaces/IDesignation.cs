using LoanManagement.Models;

namespace LoanManagement.Interfaces
{
    public interface IDesignation
    {
        Task<IEnumerable<dynamic>> GetDesignationListAsync();
        Task<Designation> GetDesignationByIdAsync(int id);
        Task<bool> CreateOrUpdate(Designation designation, int flag);
        Task<Designation> DeleteDesignationAsync(int id);
    }
}
