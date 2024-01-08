using LoanManagement.Models;

namespace LoanManagement.Interfaces
{
    public interface IMenu
    {
        Task<IEnumerable<dynamic>> GetMenuListAsyncByRollId(int rolId);
        Task<IEnumerable<dynamic>> GetMenuListAsync();
        Task<bool> CreateOrUpdate(Menu menu, int flag);
        Task<dynamic>GetMenuById(int id);

    }
}
