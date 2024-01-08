using LoanManagement.DataContext;
using LoanManagement.Interfaces;
using LoanManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanManagement.Repositorys
{
    public class MenuRepository: IMenu
    {
        private readonly DatabaseContext _context;
        public MenuRepository(DatabaseContext context) { _context = context; }

        public async Task<bool> CreateOrUpdate(Menu menu, int flag)
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

        public async Task<dynamic> GetMenuById(int id)
        {
            try
            {
                var res=await _context.Menus.Where(x => x.MenuId == id).FirstOrDefaultAsync();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMenuListAsync()
        {
            try
            {
                var res=await _context.Menus.ToListAsync();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<dynamic>> GetMenuListAsyncByRollId(int rolId)
        {
            try
            {
                var res=await _context.Menus.ToListAsync();   
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
