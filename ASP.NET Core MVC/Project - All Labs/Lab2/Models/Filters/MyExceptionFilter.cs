using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Lab2.Models.Filters
{
    public class MyExceptionFilter : ActionFilterAttribute
    {
        
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception != null)
            {
                context.ExceptionHandled = true;
                context.Result = new ContentResult { Content = "Error Happend, Please Contact US!" };
            }
            base.OnActionExecuted(context);
        }
    }
}
