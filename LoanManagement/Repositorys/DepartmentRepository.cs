using LoanManagement.DataContext;
using LoanManagement.Interfaces;
using LoanManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace LoanManagement.Repositorys
{

    public class DepartmentRepository:IDepartment
    {
        private readonly IConfiguration configuration;
        private readonly DatabaseContext _context;
        public DepartmentRepository(DatabaseContext context, IConfiguration configuration)
        {
            _context = context;
            this.configuration = configuration;
        }

        public async Task<bool> CreateOrUpdate(Department department, int flag)
        {
            string connectionString = configuration.GetConnectionString("LoanContext");
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {

                    using (NpgsqlCommand cmd = new NpgsqlCommand("public.spdepartment", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_department_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = department.DepartmentId;
                        cmd.Parameters.Add("p_department_name", NpgsqlTypes.NpgsqlDbType.Text).Value = department.DepartmentName;
                        cmd.Parameters.Add("p_department_description", NpgsqlTypes.NpgsqlDbType.Text).Value = department.DepartmentDescription;
                        cmd.Parameters.Add("p_company_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = department.CompanyId;
                        cmd.Parameters.Add("p_created_at", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DateTime.Now;
                        cmd.Parameters.Add("p_updated_at", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DateTime.Now;
                        cmd.Parameters.Add("p_created_by", NpgsqlTypes.NpgsqlDbType.Integer).Value = department.CreatedBy;
                        cmd.Parameters.Add("p_updated_by", NpgsqlTypes.NpgsqlDbType.Integer).Value = department.UpdatedBy;
                        cmd.Parameters.Add("flags", NpgsqlTypes.NpgsqlDbType.Integer).Value = flag;

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

        public Task<Department> DeleteDepartmentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetDepartmentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<dynamic>> GetDepartmentListAsync()
        {
            try
            {
                var data=await _context.Departments.Select(x=>new
                {
                    DepartmentId=x.DepartmentId,
                    DepartmentName=x.DepartmentName,
                    DepartmentDescription=x.DepartmentDescription
                }).ToListAsync();
                return data;
               
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
