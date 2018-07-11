using AirportApi.Models;
using AirportWebApi.BL;
using AirportWebApi.DAL.Models;
using AirportWebApi.DAL.Repositories;
using AirportWebAPI.BL;
using AirportWebAPI.DataAccessLayer.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
            // Add framework services.
            //services.AddSingleton<IHouseRepository, HouseRepository>();
            //services.AddTransient<IHouseMapper, HouseMapper>();
            //services.AddMvc();

            //services.AddAutoMapper();

            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HouseModel, HouseDto>();
            }).CreateMapper();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Plane, PlaneDto>();
                //cfg.CreateMap<AirplaneDTO, Airplane>();

                //cfg.CreateMap<AirplaneType, AirplaneTypeDTO>()
                //    .ForMember(a => a.Speed, opt => opt.Ignore())
                //    .ForMember(a => a.FlightRange, opt => opt.Ignore());
                //cfg.CreateMap<AirplaneTypeDTO, AirplaneType>();


                cfg.CreateMap<Ticket, TicketDto>();
                //cfg.CreateMap<TicketDTO, Ticket>();

                cfg.CreateMap<Flight, FlightDto>();
                //cfg.CreateMap<FlightDto, Flight>();

                cfg.CreateMap<Crew, CrewDto>();
                //cfg.CreateMap<CrewDto, Crew>();

                cfg.CreateMap<Pilot, PilotDto>();
                //cfg.CreateMap<PilotDTO, Pilot>();

                cfg.CreateMap<FlightAttendant, FlightAttendantDto>();
                /*cfg.CreateMap<HostessDTO, Hostess>()*/
                ;



                //cfg.CreateMap<Location, LocationDTO>()
                //    .ForMember(l => l.GeoData, opt => opt.Ignore())
                //    .ForMember(l => l.AirportName, opt => opt.Ignore()); ;
                //cfg.CreateMap<LocationDTO, Location>();

            });

            services.AddMvc();

            services.AddSingleton<IRepository<HouseModel>, PilotRepository>();
            services.AddTransient<IService<HouseDto>, PilotService>();
            services.AddScoped(_ => mapper);

            ////

            //services.AddMvc(opt =>
            //{
            //    opt.Filters.Add(typeof(ValidatorActionFilter));
            //}).AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<Startup>());


        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
