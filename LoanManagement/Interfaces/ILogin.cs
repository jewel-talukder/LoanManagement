using LoanManagement.Models;

namespace LoanManagement.Interfaces
{
    public interface ILogin
    {
        Task<IEnumerable<UserList>> GetUserListAsync();
        Task<UserList> GetUserAsync(int id);
        Task<UserList> AddUserAsync(UserList user);
        Task<UserList> UpdateUserAsync(UserList user);
        Task<UserList> LoginUser(UserList user);


    }
}
