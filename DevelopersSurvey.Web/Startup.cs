// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the Startup type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using DevelopersSurvey.Contracts.DataContracts;
using DevelopersSurvey.DA.Models;

namespace DevelopersSurvey.Web
{
    using DevelopersSurvey.Contracts.Repositories;
    using DevelopersSurvey.Contracts.Services;
    using DevelopersSurvey.DA;
    using DevelopersSurvey.DA.Repositories;
    using DevelopersSurvey.Services.Services;
    using DevelopersSurvey.Web.Identity.Models;
    using DevelopersSurvey.Web.Identity.Services;

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.AspNetCore.SpaServices.Webpack;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// The startup.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="env">
        /// The env.
        /// </param>
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                // For more details on using the user secret store see https://go.microsoft.com/fwlink/?LinkID=532709
                builder.AddUserSecrets<Startup>();
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        /// <summary>
        /// The configure services.
        /// </summary>
        /// <param name="services">
        /// The services.
        /// </param>
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc();
            
            // Add application services.
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();

            // Add repositories
            services.AddScoped<IRespondentsRepository, RespondentsRepository>();
            services.AddScoped<IFrameworksRepository, FrameworksRepository>();
            services.AddScoped<IDatabasesRepository, DatabasesRepository>();
            services.AddScoped<IProgrammingLanguagesRepository, ProgrammingLanguagesRepository>();
            services.AddScoped<IExperianceRepository, ExperianceRepository>();

            // Add services
            services.AddScoped<IRespondentsService, RespondentsService>();
            services.AddScoped<IFrameworksService, FrameworksService>();
            services.AddScoped<IDatabasesService, DatabasesService>();
            services.AddScoped<IProgrammingLanguagesService, ProgrammingLanguagesService>();
            services.AddScoped<IExperianceService, ExperianceService>();

            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RespondentDto, Respondent>();
                cfg.CreateMap<Respondent, RespondentDto>();
                cfg.CreateMap<DatabasesDto, Databases>();
                cfg.CreateMap<Databases, DatabasesDto>();
                cfg.CreateMap<FrameworksDto, Frameworks>();
                cfg.CreateMap<Frameworks, FrameworksDto>();
                cfg.CreateMap<ProgrammingLanguagesDto, ProgrammingLanguages>();
                cfg.CreateMap<ProgrammingLanguages, ProgrammingLanguagesDto>();
                cfg.CreateMap<ExperianceDto, Experiance>();
                cfg.CreateMap<Experiance, ExperianceDto>();
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        /// <summary>
        /// The configure.
        /// </summary>
        /// <param name="app">
        /// The app.
        /// </param>
        /// <param name="env">
        /// The env.
        /// </param>
        /// <param name="loggerFactory">
        /// The logger factory.
        /// </param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseBrowserLink();

                app.UseWebpackDevMiddleware(
                    new WebpackDevMiddlewareOptions
                    {
                        HotModuleReplacement = true,
                        ReactHotModuleReplacement = true
                    });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseIdentity();

            // Add external authentication middleware below. To configure them please see https://go.microsoft.com/fwlink/?LinkID=532715
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
