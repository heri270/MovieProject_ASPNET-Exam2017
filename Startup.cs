using aspnet_exam_movie.Models;
using aspnet_exam_movie.Models.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace aspnet_exam_movie
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection servises)
        {
            servises.AddDbContext<MyDbContext>();
            servises.AddMvc();
            servises.AddScoped<IMovieRepository, MovieRepository>();
        }

       public void Configure(IApplicationBuilder app, ILoggerFactory logger, MyDbContext context)
       {
            app.UseStaticFiles();
            logger.AddConsole();
            app.UseMvcWithDefaultRoute();
            DbInitializer.Initialize(context);
       }
    }
}