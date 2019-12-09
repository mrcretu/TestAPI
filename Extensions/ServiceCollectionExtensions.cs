using Microsoft.AspNetCore.Builder;
using OMRO.Helpers;
using OMRO.Middlewares;

namespace OMRO.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IApplicationBuilder UseHeadersMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<Middleware>();
        }

        public static IApplicationBuilder UseSecurityHeadersMiddleware(this IApplicationBuilder app, SecurityHeadersBuilder builder)
        {
            SecurityHeaderPolicy policy = builder.Build();
            return app.UseMiddleware<SecurityHeadersMiddleware>(policy);
        }
    }
}
