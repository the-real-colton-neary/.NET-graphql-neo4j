namespace backend.Entities;

public class User
{
    public string? FirstName { get; set; }  = default!;

    public string? LastName { get; set; } = default!;

    public string? Email { get; set; } = default!;

    public string? PhoneNumber {get; set;} = default!;

    public DateTime? CreatedAt { get; set; } = default!;

    public DateTime? UpdatedAt { get; set; } = default!;
    
    public DateTime? DeletedAt { get; set; } = default!;

    public bool? IsAdmin { get; set; } = false;

    public string? Role { get; set; } = default!;


}