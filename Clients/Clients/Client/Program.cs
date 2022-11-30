using AFirstEndpoint.Dtos;
using System.Net.Http.Json;

using var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://localhost:7145");

var response = await httpClient.GetAsync("/persons");
response.EnsureSuccessStatusCode();
var persons = await response.Content.ReadFromJsonAsync<PersonDto[]>();

foreach (var person in persons)
    Console.WriteLine($"{person.Id} - {person.Name} - {person.City}");

var newPerson = new PersonDto { Name = "Beth", City = "Amsterdam" };
var postResponse = await httpClient.PostAsJsonAsync("/persons", newPerson);
var postedPerson = await postResponse.Content.ReadFromJsonAsync<PersonDto>();

Console.WriteLine($"{postedPerson.Name} is posted with id {postedPerson.Id}");

Console.ReadKey();