using System.Diagnostics;

namespace Lab2.Middlewares
{
    public class ProfilingMiddleware 
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ProfilingMiddleware> _logger;

        // First Constraints
        public ProfilingMiddleware(RequestDelegate next, ILogger<ProfilingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        // Second Constraint
        public async Task Invoke(HttpContext context)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            await _next(context);
            sw.Stop();
            _logger.LogInformation($"Request `{context.Request.Path}` took {sw.ElapsedMilliseconds}ms to execute");
        }

    }
}
