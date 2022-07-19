using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectAPI.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;
using ProjectAPI.Repository;

namespace ProjectAPI
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
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IEmployeeModelRepo, EmployeeModelRepo>();
            services.AddScoped<ILeaveTypeRepo, LeaveTypeRepo>();
            services.AddScoped<IManagerModelRepo, ManagerModelRepo>();
            services.AddScoped<ILeaveSectionRepo, LeaveSectionRepo>();
            services.AddCors(option => option.AddDefaultPolicy
          (b => b.WithOrigins("*").AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProjectAPI", Version = "v1" });
            });
            services.AddDbContextPool<DataAccessLayerDB>(Option => Option.UseSqlServer(Configuration.GetConnectionString("MyConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProjectAPI v1"));
            }

            app.UseRouting();

            app.UseAuthorization();
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
