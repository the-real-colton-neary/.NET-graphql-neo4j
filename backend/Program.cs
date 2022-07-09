using backend.Entities;
using backend.GraphQL;
using backend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var connectionString = Environment.GetEnvironmentVariable("ConnectionString")
 ?? "Host=localhost;Username=colddong;Password=ldqDXoXyfjfM3W14iCSPRSEX7RmfS6MsZ4;Database=colddong";

builder.Services.AddPooledDbContextFactory<DataContext>(
    onions => onions.UseNpgsql(connectionString));

builder.Services.AddTransient<UserService>();

builder.Services
    .AddGraphQLServer()
    // .RegisterDbContext<DataContext>(DbContextKind.Pooled)
    .RegisterService<UserService>()
    .AddQueryType<QueryData>();
    // .ModifyRequestOptions(opt => opt.IncludeExceptionDetails = true);



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.UseSwagger();
    // app.UseSwaggerUI();
}



app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();
app.MapGraphQL();

app.Run();
