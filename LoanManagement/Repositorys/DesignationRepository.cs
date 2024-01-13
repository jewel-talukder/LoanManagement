using LoanManagement.DataContext;
using LoanManagement.Interfaces;
using LoanManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Npgsql;

namespace LoanManagement.Repositorys
{
    public class DesignationRepository : IDesignation
    {
        private readonly DatabaseContext _context;
        private readonly IConfiguration configuration;
        public DesignationRepository(DatabaseContext context,IConfiguration configuration)
        {
            _context = context;
            this.configuration = configuration;
        }
        public async Task<bool> CreateOrUpdate(Designation designation, int flag)
        {
            string connectionString = configuration.GetConnectionString("LoanContext");
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {

                    using (NpgsqlCommand cmd = new NpgsqlCommand("public.spdesignation", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_designation_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = designation.DesignationId;
                        cmd.Parameters.Add("p_designation_name", NpgsqlTypes.NpgsqlDbType.Text).Value = designation.DesignationName;
                        cmd.Parameters.Add("p_designation_description", NpgsqlTypes.NpgsqlDbType.Text).Value = designation.DesignationDescription;
                        cmd.Parameters.Add("p_department_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = designation.DepartmentId;
                        cmd.Parameters.Add("p_company_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = designation.CompanyId;
                        cmd.Parameters.Add("p_created_at", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DateTime.Now;
                        cmd.Parameters.Add("p_updated_at", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DateTime.Now;
                        cmd.Parameters.Add("p_created_by", NpgsqlTypes.NpgsqlDbType.Integer).Value = designation.CreatedBy;
                        cmd.Parameters.Add("p_updated_by", NpgsqlTypes.NpgsqlDbType.Integer).Value = designation.UpdatedBy;
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

        public Task<Designation> DeleteDesignationAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Designation> GetDesignationByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<dynamic>> GetDesignationListAsync()
        {
            try
            {
                var res = await _context.Designations.Select(x => new
                {
                    DesignationId= x.DesignationId,
                    DesignationName = x.DesignationName,
                    DepartmentId = x.DepartmentId,
                    DesignationDescription = x.DesignationDescription,
                    DepartmentName = _context.Departments.Where(y => y.DepartmentId == x.DepartmentId).Select(y => y.DepartmentName).FirstOrDefault(),


                }).ToListAsync();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
