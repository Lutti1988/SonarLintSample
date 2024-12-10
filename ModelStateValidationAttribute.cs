using Microsoft.AspNetCore.Mvc.Filters;

namespace SonarLintIssueSample;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
public sealed class ModelStateValidationAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        ArgumentNullException.ThrowIfNull(context);

        if (context.ModelState is not null
            && !context.ModelState.IsValid)
        {
            throw new InvalidModelStateException();
        }
    }
}
