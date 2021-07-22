using Framework.AssemblyHelper;
using Framework.Core.DependencyInjection;
using Framework.Core.Persistence;
using Framework.Domain;
using Microsoft.AspNetCore.Authentication.JwtBearer;
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
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MOMS.Persistence;
using MOMS.ReadModel.DataBase;
using MOMS.ReadModel.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<MOMSDbContext>()
    .AddDefaultTokenProviders();

            services.AddControllers();
            var assemblyDiscovery = new AssemblyDiscovery("MOMS*.dll");
            var registrars = assemblyDiscovery.DiscoverInstances<IRegistrar>("MOMS").ToList();
            foreach (var registrar in registrars)
            {
                registrar.Register(services, assemblyDiscovery); ;
            }

            services.AddHttpContextAccessor();


            services.AddDbContext<IDbContext, MOMSDbContext>(op =>
            {
                op.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

            });
            services.AddDbContext<MOMSDbContext>(op =>
            {
                op.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

            });
            services.AddHttpClient();


            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(Configuration["jwt:key"])),
                    ClockSkew = TimeSpan.Zero
                });

            services.AddDbContext<MOMS_DeveloperContext>(op =>
            {
                op.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                op.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "tomsAuth"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                { 
                {
                   new OpenApiSecurityScheme
                   {
                      Reference = new OpenApiReference {
                      Type = ReferenceType.SecurityScheme,
                      Id = "tomsAuth" }
                   }, new List<string>() }
                 });
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

            app.UseAuthentication();
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
