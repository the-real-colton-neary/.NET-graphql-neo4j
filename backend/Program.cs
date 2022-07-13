using Neo4j.Driver;
using backend.GraphQL;
using backend.Entities;
using HotChocolate.Data.Neo4J.Execution;
using HotChocolate.Data.Neo4J;

var builder = WebApplication.CreateBuilder(args);

IDriver driver = GraphDatabase.Driver("neo4j://localhost:7687", AuthTokens.Basic("neo4j", "ldqDXoXyfjfM3W14iCSPRSEX7RmfS6MsZ4"));


builder.Services
    .AddSingleton<IDriver>(driver)
    .AddGraphQLServer()
    .AddNeo4JFiltering()
    .AddNeo4JSorting()
    .AddNeo4JProjections()
    .AddQueryType<QueryData>()
    .AddMutationType<Mutations>()

    .ModifyRequestOptions(opt => opt.IncludeExceptionDetails = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.UseSwagger();
    // app.UseSwaggerUI();
}
app.MapGraphQL();

await app.RunAsync();
