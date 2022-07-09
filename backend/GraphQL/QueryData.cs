using backend.Entities;
using backend.Services;

namespace backend.GraphQL
{
    public class QueryData
    {
        private UserService _users;

        public QueryData(UserService UserService)
        {
            _users = UserService;
        }

        // asyncrhonously get all users with UserService
        public IEnumerable<User> GetAllUsers()
            => _users.GetAllUsers();


        public string GetHello()
            => "Hello World";

        // asyncrhonously get all user by email with UserService
        public async Task<User> GetUser(string email)
            => await _users.GetUserByEmail(email);

        
    }
}