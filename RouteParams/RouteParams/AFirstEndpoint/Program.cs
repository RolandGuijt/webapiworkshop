using AFirstEndpoint;
using EntityFramework.Database;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddDbContext<PersonDbContext>();

var app = builder.Build();

app.MapGet("/", () => "Hello world");
app.MapGet("/data", (IPersonRepository repo) => repo.GetPersons());
app.MapGet("/person/{personId}", (int personId, IPersonRepository repo) =>
{
    var personDto = repo.GetPerson(personId);
    if (personDto == null)
        return Results.NotFound();
    return Results.Ok(personDto);
});

app.Run();
