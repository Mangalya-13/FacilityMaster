using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacilityMaster.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;


namespace FacilityMaster
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //services.AddControllers();
            services.AddDbContext<CrsContext>(item => item.UseSqlServer(Configuration.GetConnectionString("MasterDataDB")));
            services.AddScoped<Repository.FacilityDetails, Repository.FacilityManagement>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoint(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});
        }
    }
}
