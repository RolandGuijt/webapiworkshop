using AFirstEndpoint;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
var app = builder.Build();

app.MapGet("/", () => "Hello world");
app.MapGet("/data", (IPersonRepository repo) => repo.GetPersons());

app.Run();
