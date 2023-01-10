using ConsoleAppToWebApi.Repository;
using ConsoleAppToWebApi.Repositroy;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ConsoleAppToWebApi
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleWare1>();

            //services.AddSingleton<IProductReposiotry, ProductReposiotry>();
            //services.AddScoped<IProductReposiotry, ProductReposiotry>();
            services.AddTransient<IProductReposiotry, TestRepository>();
            services.AddTransient<IProductReposiotry, ProductResposiotry>();
        }
        public void Configure(IApplicationBuilder applicationBuilder, IWebHostEnvironment env)
        { 

            //applicationBuilder.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello use 1-1\n");
            //    await next();
            //    await context.Response.WriteAsync("Hello use 1-2 \n");

            //});
            //applicationBuilder.UseMiddleware<CustomMiddleWare1>();
            //applicationBuilder.Map("/Marvels", CustomCode);
            //applicationBuilder.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello use 3-1 \n");
            //    await next();
            //    await context.Response.WriteAsync("Hello use 3-2 \n");

            //});
            //applicationBuilder.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request end\n");
            //    await next();

            //});

            //applicationBuilder.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello From Run \n");
            //});
            if (env.IsDevelopment())
            {
                applicationBuilder.UseDeveloperExceptionPage();
            }

            applicationBuilder.UseRouting();
            applicationBuilder.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello From new Web API app");
                //});
                //endpoints.MapGet("/Home", async context =>
                //{
                //    await context.Response.WriteAsync("HOME PAGE");
                //});
            });
        }

        private void CustomCode(IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello Marvel Cinematic universe : \n");
                await next();
            });
            
        }
    }
}
