using Soenneker.Tests.HostedUnit;

namespace Soenneker.Box.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class BoxOpenApiClientRunnerTests : HostedUnitTest
{
    public BoxOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
