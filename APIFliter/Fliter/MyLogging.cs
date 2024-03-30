using Microsoft.AspNetCore.Mvc.Filters;

namespace APIFliter.Fliter
{
    public class MyLogging :Attribute, IActionFilter
    {
        private readonly string _callerName;

        public MyLogging(string callerName)
        {
            _callerName = callerName;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"Filter Executed before {_callerName}");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"Filter Executed After {_callerName}");

        }
    }
}
