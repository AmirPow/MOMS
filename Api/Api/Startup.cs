using Framework.AssemblyHelper;
using Framework.Core.DependencyInjection;
using Framework.Core.Persistence;
using Framework.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MOMS.Persistence;
using MOMS.ReadModel.DataBase;
using MOMS.ReadModel.DataBase.Models;
using MOMS.UserContext.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            var assemblyDiscovery = new AssemblyDiscovery("MOMS*.dll");
            var registrars = assemblyDiscovery.DiscoverInstances<IRegistrar>("MOMS").ToList();
            foreach (var registrar in registrars)
            {
                registrar.Register(services, assemblyDiscovery); ;
            }

            services.AddHttpContextAccessor();
            services.AddIdentity<ApplicationUser, IdentityRole>();
            services.AddDbContext<IDbContext, MOMSDbContext>(op =>
            {
                op.UseSqlServer("data source= 185.55.224.3 ;Initial Catalog=dahriman_MOMS  ;User Id=dahriman_AdminUser ;password=@N379645099_A_M ;");

            });

            services.AddDbContext<MOMS_DeveloperContext>(op =>
            {
                op.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                op.UseSqlServer("data source= 185.55.224.3 ;Initial Catalog=dahriman_MOMS  ;User Id=dahriman_AdminUser ;password=@N379645099_A_M ;");
            });





            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api", Version = "v1" });
            });

            services.AddCors();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test Of MOMS");
                c.RoutePrefix = string.Empty;
            });



            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "MOMS V1");
            });

            if (env.IsProduction() || env.IsStaging() || env.IsEnvironment("Staging_2"))
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseExceptionHandler(a => a.Run(async context =>
            {

                var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();

                var exception = exceptionHandlerPathFeature.Error;
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                string result;
                if (exception is DomainException)
                {

                    result = JsonSerializer.Serialize(new { message = exception.Message });
                }
                else
                {
                    result = JsonSerializer.Serialize(new { message = "خطای سمت سرور" });
                }
                await context.Response.WriteAsync(result);
            }));

            app.UseHttpsRedirection();
            
            app.UseRouting();
            
            app.UseAuthorization();

            app.UseCors(builder =>
                builder.WithOrigins("*")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
            );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

        }
    }
}
