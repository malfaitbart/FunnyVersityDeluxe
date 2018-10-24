
using FunnyVersityDeluxe.API.Controllers.Courses;
using FunnyVersityDeluxe.API.Controllers.Professors;
using FunnyVersityDeluxe.API.Helpers;
using FVD.Services;
using FVD.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NJsonSchema;
using NSwag.AspNetCore;
using System.Reflection;

namespace FunnyVersityDeluxe
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton<IProfessorService, ProfessorService>();
            services.AddSingleton<ICourseService, CourseService>();
			services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<ProfessorMapper>();
            services.AddSingleton<CourseMapper>();

			services.AddSwagger();

			services.AddAuthentication("BasicAuthentication")
			   .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwaggerUi3WithApiExplorer(settings =>
            {
                settings.GeneratorSettings.DefaultPropertyNameHandling =
                    PropertyNameHandling.CamelCase;
            });

			app.UseHttpsRedirection();

			app.UseMvc();

			app.UseAuthentication();

			app.Run(async context => {
                context.Response.Redirect("/swagger");
            });
        }
    }
}
