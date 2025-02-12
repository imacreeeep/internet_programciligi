namespace WebApplication2.middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("istek alındı." + context.Request.Path);
            await _next(context);
            Console.WriteLine("yanıt gönderildi.");
        }
    }
}
