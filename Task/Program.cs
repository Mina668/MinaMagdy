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
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var employeeService = services.GetRequiredService<IEmployeeServices>();

                ApplicationConfiguration.Initialize();
                Application.Run(new Form1(employeeService));
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