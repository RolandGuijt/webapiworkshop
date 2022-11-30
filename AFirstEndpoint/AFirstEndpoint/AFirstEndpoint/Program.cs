using AFirstEndpoint;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello world");
app.MapGet("/data", () => new Person { Id = 2, Name = "Lucy", City = "London"});

app.Run();
