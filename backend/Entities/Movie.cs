using HotChocolate.Data.Neo4J.Execution;

namespace backend.Entities
{
    public class Movie
    {
        public string? Title { get; set; } = default!;

        public static explicit operator Neo4JExecutable<object>(Movie v)
        {
            throw new NotImplementedException();
        }
    }
}