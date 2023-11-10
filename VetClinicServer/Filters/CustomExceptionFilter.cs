using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetClinicServer.Exceptions;

namespace VetClinicServer.Filters
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is ResourceNotFoundException)
            {
                context.Result = new NotFoundObjectResult(new { message = context.Exception.Message });
                context.ExceptionHandled = true;
            }
            else if (context.Exception is DbUpdateException)
            {
                context.Result = new BadRequestObjectResult(new { message = context.Exception.Message });
                context.ExceptionHandled = true;
            }
        }
    }
}
