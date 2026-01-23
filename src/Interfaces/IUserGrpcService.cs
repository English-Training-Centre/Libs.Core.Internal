using Libs.Core.Internal.src.DTOs.Requests;
using Libs.Core.Internal.src.DTOs.Responses;
using Libs.Core.Shared.src.DTOs.Responses;

namespace Libs.Core.Internal.src.Interfaces;

public interface IUserGrpcService
{
    Task<UserCreatedResponse> CreateAsync(UserCreateRequest request, CancellationToken ct);
    Task<IReadOnlyList<UserGetAllResponse>> GetAllByIdsAsync(IReadOnlyCollection<Guid> ids, CancellationToken ct);
    Task<ResponseDTO> UpdateAsync(UserUpdateRequest request, CancellationToken ct);
    Task<ResponseDTO> DeleteAsync(Guid id, CancellationToken ct);
}