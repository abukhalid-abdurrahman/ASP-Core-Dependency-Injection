using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DI
{
    public class QueryMiddleware
    {
        private readonly RequestDelegate _next;
        int queryCounter = 0;
        public QueryMiddleware(RequestDelegate next)
        {
            next = _next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            queryCounter++;
            httpContext.Response.ContentType = "text/html;charset=utf-8";
            await httpContext.Response.WriteAsync($"Request was recived: {queryCounter}");
        }
    }
}