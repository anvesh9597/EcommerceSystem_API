using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.DBContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

/// <summary>
/// ADITHYA KRISHNA KUMAR
/// </summary>

namespace Ecommerce.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<EcommerceDBContext>(opt =>
            //opt.UseSqlite(Configuration.GetConnectionString("DbConnection")));

        //    < connectionStrings >

        //< add connectionString = "Data Source=ADITHYA-LAPTOP;Initial Catalog=OVS-Database;Integrated Security=True" providerName = "System.Data.SqlClient" name = "OVSConnection" />
     
        // </ connectionStrings >

                 services.AddDbContext<EcommerceDBContext>(opt =>
           opt.UseSqlServer(Configuration.GetConnectionString("DbConnection")));


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

            });
        }
    }
}
