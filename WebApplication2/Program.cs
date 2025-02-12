
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//middleware ekleme (güvenlik)
app.Use(async (context, next) =>
{
    Console.WriteLine("istek alındı." + context.Request.Path);
    await next();
    Console.WriteLine("yanıt gönderildi.");
});

app.MapGet("/", () => "merhaba asp.net core!");
app.Run();
