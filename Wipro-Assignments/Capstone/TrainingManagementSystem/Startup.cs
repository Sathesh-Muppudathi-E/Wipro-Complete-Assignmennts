using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TrainingManagementSystem.Data;
using TrainingManagementSystem.Repositories;
using TrainingManagementSystem.Services;
using AutoMapper; // Add this directive

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<TrainingManagementContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IBatchRepository, BatchRepository>();
        services.AddScoped<IBatchService, BatchService>();

        services.AddAutoMapper(typeof(Startup)); // Ensure AutoMapper configuration is scoped to the current assembly

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserService>();

        services.AddScoped<ICourseRepository, CourseRepository>();
        services.AddScoped<ICourseService, CourseService>();

        services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();
        services.AddScoped<IEnrollmentService, EnrollmentService>();

        services.AddControllers();

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "TrainingManagementSystem", Version = "v1" });
        });
    }

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

        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "TrainingManagementSystem v1");
        });
    }
}
