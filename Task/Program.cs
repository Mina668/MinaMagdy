using Task.businessLayer ;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Task.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Task.CoreLayer.UnitOfWork;
namespace Task
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<TaskDbContext>(options=>
                        options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));
                    services.AddScoped<IUnitOfWork, UnitOfWork>();
                    services.AddScoped<IEmployeeServices, EmployeeService>();
                })
                .Build();
            using(var Scope = host.Services.CreateScope())
            {
                var services = Scope.ServiceProvider;
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1(services));
            }
           static IHostBuilder CreateHostbuilder()
           {
                return Host.CreateDefaultBuilder().ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.SetBasePath(AppContext.BaseDirectory).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true);
                });
           }
        }
    }
}