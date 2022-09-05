using GloboTicket.TicketManagement.Application.Exceptions;
using Newtonsoft.Json;
using System.Net;

namespace GloboTicket.TicketManagement.Api.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await ConvertExcption(context, ex);
            }
        }

        private static Task ConvertExcption(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            var result = string.Empty;

            HttpStatusCode httpStatusCode;
            switch (ex)
            {
                case ValidationException validationExcption:
                    httpStatusCode = HttpStatusCode.BadRequest;
                    result = JsonConvert.SerializeObject(validationExcption.ValdationErrors);
                    break;
                case BadRequestException badRequestException:
                    httpStatusCode = HttpStatusCode.BadRequest;
                    result = badRequestException.Message;
                    break;
                case NotFoundException notFoundException:
                    httpStatusCode = HttpStatusCode.NotFound;
                    break;
                default:
                    httpStatusCode = HttpStatusCode.BadRequest;
                    break;
            }

            context.Response.StatusCode = (int)httpStatusCode;
            if(result == string.Empty)
            {
                result = JsonConvert.SerializeObject(new { error = ex.Message });
            }

            return context.Response.WriteAsync(result);
        }
    }
}
