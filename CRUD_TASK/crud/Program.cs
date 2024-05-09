using crud;
using crud.Data.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{      
    
    public static void Main(string[] args)
    {
        //var host = CreateHostBuilder(args).Build();


        //using var scope = host.Services.CreateScope();
        //var services = scope.ServiceProvider.GetRequiredService<IServiceCollection>();
        //var startup = new Startup(host.Services.GetRequiredService<IConfiguration>());
        //startup.ConfigureServices(services);






    }

    //public static IHostBuilder CreateHostBuilder(string[] args) =>
    //    Host.CreateDefaultBuilder(args)
    //        .ConfigureServices((context, services) =>
    //        {
                
    //            services.AddSingleton<IConfiguration>(context.Configuration);
    //        });
}