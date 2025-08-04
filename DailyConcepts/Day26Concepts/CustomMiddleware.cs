using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Day26Concepts
{
    public class CustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from new File 1  - 1\n");

            await next(context);

            await context.Response.WriteAsync("Hello from new Files 1  - 2 \n");
        }
    }
}
