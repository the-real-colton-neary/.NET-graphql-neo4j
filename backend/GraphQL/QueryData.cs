
using backend.Entities;
using HotChocolate.Data.Neo4J;
using HotChocolate.Data.Neo4J.Execution;
using Neo4j.Driver;

namespace backend.GraphQL;
public class QueryData
{

    [GraphQLName("authors")]
    [UseNeo4JDatabase("neo4j")]
    [UseProjection]
    [UseSorting]
    [UseFiltering]
    public Neo4JExecutable<User> GetUsers([ScopedService] IAsyncSession session) => new (session);

    [GraphQLName("authors")]
    [UseNeo4JDatabase(databaseName: "neo4j")]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public Neo4JExecutable<Author> GetAuthors([ScopedService] IAsyncSession session) => new (session);