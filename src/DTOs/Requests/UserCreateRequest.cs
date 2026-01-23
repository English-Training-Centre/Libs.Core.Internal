namespace Libs.Core.Internal.src.DTOs.Requests;

public sealed record UserCreateRequest
(
    string FullName,
    string PhoneNumber,
    string? Email,    
    Guid RoleId
);