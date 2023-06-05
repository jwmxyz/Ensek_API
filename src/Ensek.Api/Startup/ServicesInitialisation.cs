using Microsoft.OpenApi.Models;
using System.Reflection;

namespace Ensek.Api.Startup
{
    public static class ServicesInitialisation
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services, WebApplicationBuilder builder) {
            RegisterSwagger(services);
            RegisterDatabaseContextDependencies(services);
            RegisterCustomDependencies(services);
            RegisterLoggingDependencies(services, builder);  
            return services;
        }

        private static void RegisterCustomDependencies(IServiceCollection services)
        {
            //todo
        }

        private static void RegisterLoggingDependencies(IServiceCollection services, WebApplicationBuilder builder)
        {
            //todo
        }

        private static void RegisterDatabaseContextDependencies(IServiceCollection services)
        {
           // todo
        }

        /// <summary>
        /// Used to setup Swagger
        /// </summary>
        /// <param name="services">The startup services we wish to configure</param>
        private static void RegisterSwagger(IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Ensek Tech test meter reading uploads",
                    Description = "An API to support functionality around the uploading of Ensek Meter readings",
                    Contact = new OpenApiContact
                    {
                        Name = "John",
                        Url = new Uri("https://jwm.xyz")
                    }
                });
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });
        }

    }
}
