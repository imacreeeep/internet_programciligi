
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//middleware ekleme (g�venlik)
app.Use(async (context, next) =>
{
    Console.WriteLine("istek al�nd�." + context.Request.Path);
    await next();
    Console.WriteLine("yan�t g�nderildi.");
});

app.MapGet("/", () => "merhaba asp.net core!");
app.Run();
