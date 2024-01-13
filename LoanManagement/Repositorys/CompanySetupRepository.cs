using LoanManagement.DataContext;
using LoanManagement.Interfaces;
using LoanManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace LoanManagement.Repositorys
{
    public class CompanySetupRepository : ICompanySetUp
    {
        private readonly IConfiguration configuration;
        private readonly DatabaseContext _context;
        public CompanySetupRepository(DatabaseContext context, IConfiguration configuration)
        {
            _context = context;
            this.configuration = configuration;
        }
        public async Task<bool> CreateOrUpdate(CompanySetUP companySetUp, int flag)
        {
            string connectionString = configuration.GetConnectionString("LoanContext");
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {

                    using (NpgsqlCommand cmd = new NpgsqlCommand("public.spcompany", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_company_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = companySetUp.CompanyId;
                        cmd.Parameters.Add("p_company_name", NpgsqlTypes.NpgsqlDbType.Text).Value = companySetUp.CompanyName;
                        cmd.Parameters.Add("p_parent_company", NpgsqlTypes.NpgsqlDbType.Integer).Value = companySetUp.ParentCompany;
                        cmd.Parameters.Add("p_company_address", NpgsqlTypes.NpgsqlDbType.Text).Value = companySetUp.CompanyAddress;
                        cmd.Parameters.Add("p_company_phone1", NpgsqlTypes.NpgsqlDbType.Text).Value =companySetUp.CompanyPhone1;
                        cmd.Parameters.Add("p_company_phone2", NpgsqlTypes.NpgsqlDbType.Text).Value = companySetUp.CompanyPhone2;
                        cmd.Parameters.Add("p_company_email", NpgsqlTypes.NpgsqlDbType.Text).Value = companySetUp.CompanyEmail;
                        cmd.Parameters.Add("p_company_facebook", NpgsqlTypes.NpgsqlDbType.Text).Value = companySetUp.FacebookUrl;
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

        public Task<CompanySetUP> DeleteCompanySetUpAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CompanySetUP> GetCompanySetUpByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<dynamic>> GetCompanySetUpListAsync()
        {
            try
            {
                var res=await _context.CompanyMasters.Select( x => new { 
                    CompanyId = x.CompanyId,
                    CompanyName = x.CompanyName,
                    ParentCompany = _context.CompanyMasters.Where(p=>p.CompanyId==x.ParentCompany).Select(x=>x.CompanyName).FirstOrDefault(),
                    CompanyAddress = x.CompanyAddress,
                    CompanyPhone1 = x.CompanyPhone1,
                    CompanyPhone2 = x.CompanyPhone2,
                    CompanyEmail = x.CompanyEmail,
                    FacebookUrl = x.FacebookUrl
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
