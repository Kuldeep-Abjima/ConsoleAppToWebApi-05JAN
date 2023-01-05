namespace ConsoleAppToWebApi
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {

        }
        public void Configure(IApplicationBuilder applicationBuilder, IWebHostEnvironment env) 
        {


            applicationBuilder.UseRouting();
        }
    }
}
