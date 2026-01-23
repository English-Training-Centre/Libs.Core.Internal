namespace Libs.Core.Internal.src.DTOs.Responses;

public sealed record UserCreatedResponse
{
    public bool IsSuccess { get; init; }
    public string Message { get; init; } = string.Empty;
    public Guid UserId { get; init; }
    public string? Username { get; init; }
    public string? Password { get; init; }

    public static UserCreatedResponse Success(string message, Guid user_id, string username, string password) =>
        new()
        {
            IsSuccess = true,
            Message = message,
            UserId = user_id,
            Username = username,
            Password = password
        };

    public static UserCreatedResponse Failure(string message) =>
        new()
        {
            IsSuccess = false,
            Message = message,
        };
}