using backend.Entities;
using HotChocolate.Data.Neo4J;
using HotChocolate.Data.Neo4J.Execution;
using Microsoft.AspNetCore.Mvc;
using Neo4j.Driver;

namespace backend.GraphQL;

public class Mutations
{
    
    [GraphQLName("movies")]
    [UseNeo4JDatabase(databaseName: "neo4j")]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public Neo4JExecutable<Movie> PostMovies([ScopedService] IAsyncSession session, Movie movie) 
        => new (session);

    [GraphQLName("newMovie")]
    [UseNeo4JDatabase(databaseName: "neo4j")]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public async Task<Movie> PostBullShit([ScopedService] IAsyncSession session, Movie movie) 
        {
           
            IResultCursor cursor;

            var email = new List<string>();

            try {
                cursor = await session.RunAsync($"Create (n:Movie {{Title: '{movie.Title}'}}) RETURN n");
                email = cursor.ToListAsync(record => 
                record[0].As<string>()).Result;

            }
            finally{
                Console.WriteLine("Shit");
            }

            return movie;
        }

    // Create a 
        


}
