using DocumentFormat.OpenXml.Drawing;
using Google.Apis.Sheets.v4.Data;
using GoogleSheetsWrapper;
using LicenseManager;
using Microsoft.Extensions.DependencyInjection;

namespace CompanyEmployees
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            .WithExposedHeaders("X-Pagination"));
        });
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
        services.Configure<IISOptions>(options =>
        {
        });
        public static void ConfigureGoogleSheetsWrapper(this IServiceCollection services)
        {
            services.AddSingleton(serviceProvider =>
            {
                string spreadsheetID = "1zFjRdhagXZZYEnRfx71zIDmzJ28fPfwyRhXboEDQa0g";
                string serviceAccountEmail = "lisacore@lisacore-license.iam.gserviceaccount.com";
                string tabName = "Credantials";

                CredantialsRepository repo = new CredantialsRepository(spreadsheetID, serviceAccountEmail, tabName);
                return repo;
            });
        }
    }
}