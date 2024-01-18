using LoanManagement.DataContext;
using LoanManagement.Interfaces;
using LoanManagement.Models;
using Npgsql;

namespace LoanManagement.Repositorys
{
    public class RoleRepository : IRole
    {
        private readonly IConfiguration configuration;
        private readonly DatabaseContext _context;
        public RoleRepository(DatabaseContext context,IConfiguration configuration)
        {
            _context = context; 
            this.configuration = configuration;
        }
        public async Task<bool> CreateOrUpdate(Role role, int userId)
        {
            string connectionString = configuration.GetConnectionString("LoanContext");
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {

                    using (NpgsqlCommand cmd = new NpgsqlCommand("public.sprole", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_role_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = role.RoleId;
                        cmd.Parameters.Add("p_role_name", NpgsqlTypes.NpgsqlDbType.Text).Value = role.RoleName;
                        cmd.Parameters.Add("p_created_at", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DateTime.Now;
                        cmd.Parameters.Add("p_updated_at", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DateTime.Now;
                        cmd.Parameters.Add("p_created_by", NpgsqlTypes.NpgsqlDbType.Integer).Value = role.CreatedBy;
                        cmd.Parameters.Add("p_updated_by", NpgsqlTypes.NpgsqlDbType.Integer).Value = role.UpdatedBy;
                        cmd.Parameters.Add("flags", NpgsqlTypes.NpgsqlDbType.Integer).Value = 1;

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

        public Task<List<Role>> GetRoleListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
