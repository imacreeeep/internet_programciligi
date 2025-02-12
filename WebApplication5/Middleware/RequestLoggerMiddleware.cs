namespace WebApplication5.Middleware
{
    public class RequestLoggerMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //gelen isteği logla
            Console.WriteLine($"[{DateTime.Now}] istek geldi: {context.Request.Method}{context.Request.Path}");

            //isteği bir sonraki middleware e ilet
            await _next(context);

            //yanıt döndükten sonra logla
            Console.WriteLine($"[{DateTime.Now}] yanıt gönderildi: {context.Response.StatusCode}");
        }
    }
}
