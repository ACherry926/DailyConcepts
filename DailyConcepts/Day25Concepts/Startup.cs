using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Day25Concepts
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Day25Concepts", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Day25Concepts v1"));
            }

            app.UseHttpsRedirection();

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run 1");

            //});

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from Use 1  - 1\n");

                await next();

                await context.Response.WriteAsync("Hello from Use 1  - 2 \n");
            });

            app.Map("/Aravind", CutomCode);


            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from Use 2  - 1\n");

                await next();

                await context.Response.WriteAsync("Hello from Use 2  - 2\n");
            });

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request Completed\n");

            //});

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from Runners\n");

            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void CutomCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from Aravind\n");

            });
        }
    }
}
