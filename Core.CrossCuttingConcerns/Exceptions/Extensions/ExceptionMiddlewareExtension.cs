using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.Extensions;

public static class ExceptionMiddlewareExtension
{

    public static void ConfigureCustomExcetionMiddleware(this IApplicationBuilder app) => app.UseMiddleware<ExceptionMiddleware>();
}
