using LoanManagement.Models;

namespace LoanManagement.Interfaces
{
    public interface ILogin
    {
        Task<IEnumerable<UserList>> GetUserListAsync();
        Task<UserList> GetUserAsync(int id);
        Task<bool> AddUserAsync(UserList user);
        Task<bool> UpdateUserAsync(UserList user);
        Task<UserList> LoginUser(UserList user);


    }
}
