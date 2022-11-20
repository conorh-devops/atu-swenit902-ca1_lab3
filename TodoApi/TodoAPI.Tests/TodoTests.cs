using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
namespace TodoAPI.Tests
{
    public class TodoTests
    {
        [Fact]
        public async Task TestRootEndpoint()
        {
            await using var application = new WebApplicationFactory<Program>();
            using var client = application.CreateClient();

            var response = await client.GetStringAsync("/");
            Assert.Equal("Hello World!", response);
        }

        [Fact]
        public async Task TestCreateItem()
        {
            await using var application = new WebApplicationFactory<Program>();
            using var client = application.CreateClient();

            var response = await client.GetStringAsync("/");
            Assert.Equal("Hello World!", response);
        }

    }
}