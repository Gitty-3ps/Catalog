using System; // Unecessay check documentation on Global directives

namespace Catalog.Entities
{
    public record Item
    {
        public Guid Id { get; init; } 

        public string? Name { get; init; } // Name is a non-nullable property, thus adding ? after the data type rectifies this. See Online Documentation. 

        public decimal Price { get; init; }

        public DateTimeOffset CreatedDate { get; init; }  
    }
}