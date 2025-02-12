var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
var app = builder.Build();
app.MapGet("/products", () =>
{
    return new List<string> { "laptop", "mouse", "keyboard" };
});
app.Run();
