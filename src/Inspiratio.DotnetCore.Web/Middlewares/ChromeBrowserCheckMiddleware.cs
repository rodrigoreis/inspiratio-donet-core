using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Inspiratio.DotnetCore.Web.Middlewares
{
    public class ChromeBrowserCheckMiddleware
    {
        private readonly RequestDelegate _next;

        public ChromeBrowserCheckMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
			//TODO: Implementar a validação do browser.
            await _next(context);
        }
    }

    public static class ChromeBrowserCheckMiddlewareExtensions
    {
        public static IApplicationBuilder UseChromeBrowserCheck(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ChromeBrowserCheckMiddleware>();
        }
    }
}
