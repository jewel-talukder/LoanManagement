using LoanManagement.Models;

namespace LoanManagement.Interfaces
{
    public interface ICompanySetUp
    {
        Task<IEnumerable<dynamic>> GetCompanySetUpListAsync();
        Task<CompanySetUP> GetCompanySetUpByIdAsync(int id);
        Task<bool> CreateOrUpdate(CompanySetUP companySetUp, int flag);
        Task<CompanySetUP> DeleteCompanySetUpAsync(int id);
    }
}
