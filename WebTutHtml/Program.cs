var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => Index.Start);
app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();
