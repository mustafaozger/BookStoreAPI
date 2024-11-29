using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Entitites.ErrorModel;
using Entitites.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Services.Contracts;

namespace webapi_v1._1.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this WebApplication app, ILoggerService logger)
        {
            app.UseExceptionHandler(appError=>
            {
               appError.Run(async context=>
                {
                    context.Response.ContentType="application/json";
                    var contextFeature=context.Features.Get<IExceptionHandlerFeature>();

                    if(contextFeature is not null)
                    {
                        context.Response.StatusCode=contextFeature.Error switch 
                        {
                            NotFoundException =>StatusCodes.Status404NotFound,
                            _=>StatusCodes.Status500InternalServerError
                        };
                        logger.LogError($"Something went wrong: {contextFeature.Error}");
                        await context.Response.WriteAsync(new ErrorDetails(){
                            StatusCode=context.Response.StatusCode,
                            Message=contextFeature.Error.Message
                        }.ToString());
                    }

                }) ;
            });
        }

    }
}