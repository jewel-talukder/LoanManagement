using LoanManagement.DataContext;
using LoanManagement.Interfaces;
using LoanManagement.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Data;

namespace LoanManagement.Repositorys
{
    public class MenuRepository: IMenu
    {
        private readonly IConfiguration configuration;
        private readonly DatabaseContext _context;
        public MenuRepository(DatabaseContext context, IConfiguration configuration) { _context = context; this.configuration=configuration; }

        public async Task<bool> CreateOrUpdate(Menu menu, int flag)
        {
            string connectionString = configuration.GetConnectionString("LoanContext");
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {

                    using (NpgsqlCommand cmd = new NpgsqlCommand("public.spmenu", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_menu_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = menu.MenuId;
                        cmd.Parameters.Add("p_menu_name", NpgsqlTypes.NpgsqlDbType.Text).Value = menu.MenuName;
                        cmd.Parameters.Add("p_parent_menu", NpgsqlTypes.NpgsqlDbType.Integer).Value = menu.ParentMenu;
                        cmd.Parameters.Add("p_menu_url", NpgsqlTypes.NpgsqlDbType.Text).Value = menu.MenuUrl;
                        cmd.Parameters.Add("p_menu_icon", NpgsqlTypes.NpgsqlDbType.Text).Value = menu.MenuIcon;
                        cmd.Parameters.Add("p_menu_serial", NpgsqlTypes.NpgsqlDbType.Integer).Value = menu.MenuSerial;
                        cmd.Parameters.Add("p_menu_status", NpgsqlTypes.NpgsqlDbType.Integer).Value = menu.MenuStatus;
                        cmd.Parameters.Add("p_created_at", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DateTime.Now;
                        cmd.Parameters.Add("p_updated_at", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DateTime.Now;
                        cmd.Parameters.Add("p_created_by", NpgsqlTypes.NpgsqlDbType.Integer).Value = menu.CreatedBy;
                        cmd.Parameters.Add("p_updated_by", NpgsqlTypes.NpgsqlDbType.Integer).Value = menu.UpdatedBy;
                        cmd.Parameters.Add("flags", NpgsqlTypes.NpgsqlDbType.Integer).Value = flag;

                        //cmd.Parameters.AddWithValue("p_menu_id",Convert.ToInt32(menu.MenuId));
                        //cmd.Parameters.AddWithValue("p_menu_name",  menu.MenuName.ToString());
                        //cmd.Parameters.AddWithValue("p_parent_menu", Convert.ToInt32(menu.ParentMenu));
                        //cmd.Parameters.AddWithValue("p_menu_url", menu.MenuUrl.ToString());
                        //cmd.Parameters.AddWithValue("p_menu_icon", menu.MenuIcon.ToString());
                        //cmd.Parameters.AddWithValue("p_menu_serial",Convert.ToInt32(menu.MenuSerial));
                        //cmd.Parameters.AddWithValue("p_menu_status",Convert.ToInt32(menu.MenuStatus));
                        //cmd.Parameters.AddWithValue("p_created_at",Convert.ToDateTime(menu.CreatedAt));
                        //cmd.Parameters.AddWithValue("p_updated_at",Convert.ToDateTime(menu.UpdatedAt));
                        //cmd.Parameters.AddWithValue("p_created_by",Convert.ToInt32(menu.CreatedBy));
                        //cmd.Parameters.AddWithValue("p_updated_by",Convert.ToInt32(menu.UpdatedBy));
                        //cmd.Parameters.AddWithValue("flags",Convert.ToInt32(flag));

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
                finally
                {
                    connection.Close();
                }

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

        public  async Task<IEnumerable<dynamic>> GetMenuListAsync()
        {
            try
            {
                var res= _context.Menus.Select(x => new 
                {
                    MenuId = x.MenuId,
                    MenuName = x.MenuName??"",
                    ParentMenu = x.ParentMenu==null ?0:x.ParentMenu,
                    MenuUrl = x.MenuUrl??"",
                    MenuIcon = x.MenuIcon ?? "",
                    MenuSerial = x.MenuSerial==null?0:x.MenuSerial,
                    MenuStatus = x.MenuStatus==null?0:x.MenuStatus,
                    ParentMenuName=_context.Menus.Where(y=>y.MenuId==x.ParentMenu).Select(y=>y.MenuName).FirstOrDefault(),

                }).OrderBy(x=>x.MenuId).ToList();
                return  res;
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
