using Day27Concepts.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Day27Concepts
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Day27Concepts", Version = "v1" });
            });


            services.AddSingleton<IProductsRepository, ProductsRepository>();
            services.AddScoped<IProductsRepository, ProductsRepository>();
            services.AddTransient<IProductsRepository, ProductsRepository>();

            services.AddTransient<IProductsRepository, ProductsRepository>();
            services.AddTransient<IProductsRepository, TestRepository>();

            services.TryAddTransient<IProductsRepository, TestRepository>();
            services.TryAddTransient<IProductsRepository, ProductsRepository>();

            services.TryAddSingleton<ICounter, Counter>();
            services.TryAddTransient<IFirstCounter, FirstCounter>();
            services.TryAddTransient<ISecondCounter, SecondCounter>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Day27Concepts v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
