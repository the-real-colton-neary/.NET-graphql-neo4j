using backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Services;

public class UserService : IAsyncDisposable
{
    private readonly DataContext _dbContext;

    public UserService(IDbContextFactory<DataContext> dbContextFactory)
    {
        _dbContext = dbContextFactory.CreateDbContext();
    }

    public ValueTask DisposeAsync()
        => _dbContext.DisposeAsync();
    
    // User Methods
    public  IEnumerable<User> GetAllUsers()
        =>  _dbContext.Users.ToArray();

    public async Task<User> GetUser(int id)
        => await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id) ?? new User();

    public async Task<User> GetUserByEmail(string email)
        => await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email) ?? new User();
}
