namespace AFirstEndpoint.Dtos
{
    public record PersonDto()
    {
        public int Id { get; init; }
        public string Name { get; init; } = "Unknown";
        public string City { get; init; } = "Unknown";
    }
}
