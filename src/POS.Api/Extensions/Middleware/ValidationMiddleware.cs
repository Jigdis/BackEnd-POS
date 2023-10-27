using POS.Application.UseCase.Commons.Bases;
using POS.Application.UseCase.Commons.Exceptions;
using POS.Utilities.Constants;
using System.Text.Json;

namespace POS.Api.Extensions.Middleware
{
    public class ValidationMiddleware
    {
        public readonly RequestDelegate _next;

        public ValidationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (ValidationException ex)
            {
                context.Response.ContentType = "application/json";
                await JsonSerializer.SerializeAsync(context.Response.Body, new BaseResponse<object>
                {
                    Message = GlobalMessges.MESSAGE_VALIDATE,
                    Errors = ex.Errors
                });
            }
        }
    }
}
