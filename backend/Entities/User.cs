namespace backend.Entities;

public class User
{
    public int Id { get; set; }

    

    public string FirstName { get; set; }  = default!;

    public string LastName { get; set; } = default!;

    public string Email { get; set; } = default!;

    public string? PhoneNumber {get; set;}

    public DateTime? CreatedAt { get; set; }
    
    public DateTime? DeletedAt { get; set; }

    public bool IsAdmin { get; set; } = false;


}