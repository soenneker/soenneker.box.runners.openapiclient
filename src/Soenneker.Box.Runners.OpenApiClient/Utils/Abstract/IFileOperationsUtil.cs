using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Box.Runners.OpenApiClient.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask Process(CancellationToken cancellationToken = default);
}
