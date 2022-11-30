using AFirstEndpoint;
using EntityFramework.Database;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddDbContext<PersonDbContext>();

var app = builder.Build();

app.MapGet("/", () => "Hello world");
app.MapGet("/data", (IPersonRepository repo) => repo.GetPersons());

app.Run();
