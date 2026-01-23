using Libs.Core.Internal.src.DTOs.Responses;
using Libs.Core.Shared.src.DTOs.Requests;

namespace Libs.Core.Internal.src.Interfaces;

public interface IUserAuthGrpcService
{
    Task<UserAuthResponse> UserAuthAsync(UserAuthRequest request, CancellationToken ct);
    Task<UserAuthResponse> GetUserAuthByIdAsync(Guid id, CancellationToken ct);
}