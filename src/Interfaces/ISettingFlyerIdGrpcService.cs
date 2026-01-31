namespace Libs.Core.Internal.src.Interfaces;

public interface ISettingFlyerIdGrpcService
{
    Task<Guid> GetFlyerId(CancellationToken ct);
}