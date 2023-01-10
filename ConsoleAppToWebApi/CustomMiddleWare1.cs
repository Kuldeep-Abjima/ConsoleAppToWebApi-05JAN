namespace ConsoleAppToWebApi
{
    public class CustomMiddleWare1 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello From New File 1\n");
            await next(context);
            await context.Response.WriteAsync("Hello use New File 2\n");
        }
    }
}
