namespace Libs.Core.Internal.src.DTOs.Responses;

public sealed record UserGetAllResponse
{
    public Guid Id { get; init; }
    public string FullName { get; init; } = string.Empty;
    public string Username { get; init; } = string.Empty;
    public string PhoneNumber { get; init; } = string.Empty;
    public string? Email { get; init; }    
    public string Role { get; init; } = string.Empty;
    public string? ImageUrl { get; init; }
    public bool IsActive { get; init; }
}