using LoanManagement.DataContext;
using LoanManagement.Interfaces;
using LoanManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanManagement.Repositorys
{
    public class LoginRepository : ILogin
    {
        public readonly DatabaseContext _context;
        public LoginRepository(DatabaseContext context)
        {
            _context = context;   
        }
        public async Task<bool> AddUserAsync(UserList user)
        {
            try
            {
                await _context.UserList.AddAsync(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<UserList> GetUserAsync(int id)
        {
            try
            {
                var res= await _context.UserList.Where(x => x.UserId == id).FirstOrDefaultAsync();
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<UserList>> GetUserListAsync()
        {
            try
            {
                var data=await _context.UserList.ToListAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<UserList> LoginUser(UserList user)
        {
            try
            {
                var resss = await _context.UserList.ToListAsync();
                var res=await _context.UserList.Where(x => x.UserName == user.UserName && x.UserPassword == user.UserPassword && x.UserStatus =="Active").FirstOrDefaultAsync();
                if (res != null)
                {
                    return res;
                }
                else
                {
                    res=await _context.UserList.Where(x => x.UserPhone == user.UserName && x.UserPassword==user.UserPassword && x.UserStatus=="Active").FirstOrDefaultAsync();
                    return res;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateUserAsync(UserList user)
        {
            try
            {
                
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
