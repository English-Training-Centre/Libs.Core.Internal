namespace Libs.Core.Internal.src.DTOs.Responses;

public sealed record UserAuthResponse
{
    public bool IsSuccess { get; init; }
    public Guid? UserId { get; init; }
    public string? Username { get; init; }
    public string? FullName { get; init; }
    public string? Role { get; init; }
}

