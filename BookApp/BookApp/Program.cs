var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/*
 * Middleware Concept -- similar to nodejs 
 * app.Use(async (Context, next) =>
{
    await Context.Response.WriteAsync("hello from first middleware");
    next();
});*/
app.MapGet("/", () => "Hello World!");

app.Run();
