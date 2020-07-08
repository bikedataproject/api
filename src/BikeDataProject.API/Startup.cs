using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using BikeDataProject.Domain.Concretes;
using BikeDataProject.Domain.Declarations;
using BikeDataProject.Providers.Local.Sql.Concretes;
using BikeDataProject.Providers.Local.Sql.Declarations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BikeDataProject.API
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
            services.AddControllers();

            // Scoped permits to dispose the domain at the end of the user request
            // Database context
            services.AddScoped<IDbContext>(dbC => new DbContext(this.Configuration.GetConnectionString("PgSqlCS")));

            // Domains
            services.AddScoped<ISampleDomain, SampleDomain>();
            services.AddScoped<IGeometryDomain, GeometryDomain>();

            // Repos
            services.AddScoped<ISampleRepository, SampleRepository>();
            services.AddScoped<IGeometryRepository, GeometryRepository>();
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
