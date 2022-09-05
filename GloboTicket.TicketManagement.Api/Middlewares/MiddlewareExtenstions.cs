﻿namespace GloboTicket.TicketManagement.Api.Middlewares
{
    public static class MiddlewareExtenstions
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
