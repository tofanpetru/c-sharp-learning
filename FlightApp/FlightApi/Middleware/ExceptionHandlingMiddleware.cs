using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace FlightApi.Middleware
{
    public class ExceptionHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (NotFoundException)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
