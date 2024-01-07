using LoanManagement.Interfaces;
using LoanManagement.Repositorys;
using Microsoft.AspNetCore.Localization;
using System.Globalization;

namespace LoanManagement.ConfigureServices
{
    public static class ExtractEmService
    {
        public static void ExtractEmRegisterService(IServiceCollection services)
        {
            services.AddScoped<ILogin, LoginRepository>();
            services.AddLocalization(options => { options.ResourcesPath = "Resources"; });
            services.Configure<RequestLocalizationOptions>(
                options =>
                {
                    var supportedCultures = new List<CultureInfo>
                    {
                    new CultureInfo("bn-BD"),
                    new CultureInfo("en"),
                    new CultureInfo("ja-JP"),
                    };
                    options.DefaultRequestCulture = new RequestCulture("en");
                    options.SupportedCultures = supportedCultures;
                    options.SupportedUICultures = supportedCultures;
                });
        }
        }
}
