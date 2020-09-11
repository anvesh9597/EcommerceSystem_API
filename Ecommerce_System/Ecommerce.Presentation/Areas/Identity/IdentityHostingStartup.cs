using Ecommerce.Domain.DBContext;
using Ecommerce.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Ecommerce.Presentation.Areas.Identity.IdentityHostingStartup))]
namespace Ecommerce.Presentation.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<AuthDbContext>(options =>
            //        options.UseSqlite(
            //            context.Configuration.GetConnectionString("AuthDbContextConnection")));

            //    services.AddDefaultIdentity<ApplicationUser>(options => 
            //    {
            //        options.SignIn.RequireConfirmedAccount = false;
            //        //options.Password.RequireLowercase = false;

            //    })
            //        .AddEntityFrameworkStores<AuthDbContext>();
            //});

            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EcommerceDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthDbContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    //options.Password.RequireLowercase = false;

                })
                    .AddEntityFrameworkStores<EcommerceDBContext>();
            });
        }
    }
}