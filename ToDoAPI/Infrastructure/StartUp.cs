using Microsoft.EntityFrameworkCore;
using ToDoAPI.Data;
using ToDoAPI.Services;
using Microsoft.Extensions.Configuration;
namespace ToDoAPI.Infrastructure;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<ToDoContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped<IToDoService, ToDoService>();
        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}