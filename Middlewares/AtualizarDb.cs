using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SpaceshipManager.Database;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceshipManager.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AtualizarDb
    {
        private readonly RequestDelegate _next;

        public AtualizarDb(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, ManagerContext managerContext)
        {
            if ((await managerContext.Database.GetPendingMigrationsAsync()).Any())
                await managerContext.Database.MigrateAsync();

            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AtualizarDbExtensions
    {
        public static IApplicationBuilder UseAtualizarDb(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AtualizarDb>();
        }
    }
}
