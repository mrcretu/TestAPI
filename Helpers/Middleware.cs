using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace OMRO.Helpers
{
    public class Middleware
    {

        private readonly RequestDelegate _next;

        public Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next(context);
        }
    }
}
