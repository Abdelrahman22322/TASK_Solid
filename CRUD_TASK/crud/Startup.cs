using crud.Data.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AggregratorContracts.AggregatorServices;
using Microsoft.EntityFrameworkCore;
using ServiceContracts;
using Services;

//using IProductAggregatorServices = ServiceContracts.IProductAggregatorServices;

namespace crud
{
    public class Startup(IConfiguration configuration)
    {
        public IConfiguration Configuration { get; } = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<ApplicationContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            //services.AddDbContext<ApplicationContext>(options =>
            //               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //services.AddDbContext<ApplicationContext>(options =>
            //                  options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //services.AddSingleton<ICustomerAggregatorServices, CustomerAggregatorServices>();
            //services.AddSingleton<ICustomerAdderServices, CustomerAdderServices>();
            //services.AddSingleton<ICustomerGetterServices,  CustomerGetterServices>();
            //services.AddSingleton<ICustomerUpdaterServices, CustomerUpdaterServices>();
            //services.AddSingleton<IEmployeeAggregatorServices, IEmployeeAggregatorServices>();
            //services.AddSingleton<IEmployeeAdderServices, EmployeeAdderServices>();
            //services.AddSingleton<IEmployeeGetterServices, EmployeeGetterServices>();
            //services.AddSingleton<IEmployeeUpdaterServices, EmployeeUpdaterServices>();
            //services.AddSingleton<IEmployeeDeleterServices, EmployeeDeleterServices>();
            //services.AddSingleton<IOrderAggregatorServices, OrderAggregatorServices>();
            //services.AddSingleton<IOrderAdderServices, OrderAdderServices>();
            //services.AddSingleton<IOrderGetterServices, OrderGetterServices>();
            //services.AddSingleton<IOrderUpdaterServices, OrderUpdaterServices>();
            //services.AddSingleton<IProductAggregatorServices, ProductAggregatorServices>();
            //services.AddSingleton<IProductAddersServices, ProductAdderServices>();
            //services.AddSingleton<IProductGetterServices, ProductGetterServices>();
            //services.AddSingleton<IProductsUpdaterServices, IProductsUpdaterServices>();
            //services.AddSingleton<IProductsDeleterServices, ProductDeleterServices>();
            services.AddSingleton<ICustomerAggregatorServices, ICustomerAggregatorServices>();
            services.AddSingleton<ICustomerAdderServices, CustomerAdderServices>();
            services.AddSingleton<ICustomerGetterServices, CustomerGetterServices>();
            services.AddSingleton<ICustomerUpdaterServices, CustomerUpdaterServices>();

            // Corrected
            services.AddSingleton<IEmployeeAdderServices, EmployeeAdderServices>();
            services.AddSingleton<IEmployeeGetterServices, EmployeeGetterServices>();
            services.AddSingleton<IEmployeeUpdaterServices, EmployeeUpdaterServices>();
            services.AddSingleton<IEmployeeDeleterServices, EmployeeDeleterServices>();
           
            services.AddSingleton<IOrderAdderServices, OrderAdderServices>();
            services.AddSingleton<IOrderGetterServices, OrderGetterServices>();


            services.AddSingleton<IOrderUpdaterServices, OrderUpdaterServices>();
           
            services.AddSingleton<IProductAddersServices, ProductAdderServices>();
            services.AddSingleton<IProductGetterServices, ProductGetterServices>();
            services.AddSingleton<IProductsUpdaterServices, IProductsUpdaterServices>(); 
            services.AddSingleton<IProductsDeleterServices, ProductDeleterServices>();








        }


    }

}
