using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Box.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class BoxOpenApiClientRunnerTests : FixturedUnitTest
{
    public BoxOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
