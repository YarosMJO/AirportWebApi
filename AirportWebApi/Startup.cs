using AirportWebApi.BL;
using AirportWebApi.BL.Services;
using AirportWebApi.DAL.Models;
using AirportWebApi.DAL.Repositories;
using AirportWebAPI.DataAccessLayer.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Shared.Configs;
using Shared.Dtos;

namespace AirportWebApi
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(env.ContentRootPath)
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            var config = new AutoMapperConfiguration().Configure().CreateMapper();
            services.AddSingleton(sp => config);

            services.AddMvc().AddFluentValidation();

            services.AddSingleton<IRepository<Ticket>, TicketRepository>();
            services.AddScoped<IService<TicketDto>, TicketService>();

            services.AddSingleton<IRepository<Flight>, FlightRepository>();
            services.AddScoped<IService<FlightDto>, FlightService>();

            services.AddSingleton<IRepository<Departure>, DepartureRepository>();
            services.AddScoped<IService<DeparturesDto>, DepartureService>();

            services.AddSingleton<IRepository<Crew>, CrewRepository>();
            services.AddScoped<IService<CrewDto>, CrewService>();

            services.AddSingleton<IRepository<Pilot>, PilotRepository>();
            services.AddScoped<IService<PilotDto>, PilotService>();

            services.AddSingleton<IRepository<FlightAttendant>, FlightAttendantRepository>();
            services.AddScoped<IService<FlightAttendantDto>, FlightAttendantService>();

            services.AddSingleton<IRepository<Plane>, PlaneRepository>();
            services.AddScoped<IService<PlaneDto>, PlaneService>();

            services.AddSingleton<IRepository<PlaneType>, PlaneTypeRepository>();
            services.AddScoped<IService<PlaneTypeDto>, PlaneTypeService>();


            services.AddSingleton<IValidator<Pilot>, PilotValidator>();
            //services.AddMvc(opt =>
            //{
            //    opt.Filters.Add(typeof(ValidatorActionFilter));
            //}).AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<PilotValidator>());

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
