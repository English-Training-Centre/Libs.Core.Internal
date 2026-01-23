namespace Libs.Core.Internal.src.DTOs.Requests;

public sealed record UserUpdateRequest
(
    Guid Id,
    string FullName,
    string? Email,
    string PhoneNumber,    
    Guid RoleId
);