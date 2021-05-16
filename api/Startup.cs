using System;
using System.IO;
using System.Reflection;
using System.Text.Json.Serialization;
using HomeBuilders.Api.AuxTypes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using api.business.extensions;

namespace HomeBuilders.Api
{
    /// <summary>
    /// ASP.NET Core Start up class
    /// </summary>
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        /// <summary>
        /// Constructor method
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Configuration access prop
        /// </summary>
        /// <value></value>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins, builder =>
                {
                    builder.WithOrigins(
                            "http://localhost:3000",
                            "http://192.168.1.4:3000"
                        )
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });
            services.AddControllers();
            services.AddMvc()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                    options.JsonSerializerOptions.IgnoreNullValues = true;
                });

            // Register the Swagger Generator service. This service is responsible for genrating Swagger Documents.
            // Note: Add this service at the end after AddMvc() or AddMvcCore().
            services.AddSwaggerGen(c =>
            {
                (string dllName, string buildVersion) = GetDllInfo();
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "HomeBuilders API",
                    Version = "v1",
                    Description = $"API for Tracking Home Builder projects and Requests for follow-up. Library:{dllName.ToUpper()}. Build:{buildVersion}",
                    Contact = new OpenApiContact
                    {
                        Name = "Anibal Velarde",
                        Email = string.Empty,
                        Url = new Uri("http://anibalvelarde.com/"),
                    },
                });
                foreach (var filePath in System.IO.Directory.GetFiles(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)), "*.xml"))
                {
                    c.IncludeXmlComments(filePath);
                }
            });

            // Adding Business Layer Dependencies
            services.SetupBusinessDependencies();
        }

        private (string dllName, string buildVersion) GetDllInfo()
        {
            AssemblyInfo info = new AssemblyInfo();
            return (info.Product, info.AssemblyVersion);
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "HomeBuilders API V1");

                // To serve SwaggerUI at application's root page, set the RoutePrefix property to an empty string.
                c.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
