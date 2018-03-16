using System.Net.Http;
using DAL;
using Xunit;

namespace Tests
{
    // tests should be pipelined - if we fail here, no point running anything else
    // HttpClient() lifecycle should be reconsidered, as well as creating ApiSettings() everytime
    public class ApiAccessTests
    {

        [Fact]
        public async void ApiAcess_ValidKey_SuccessStatusCode()
        {
            var client = new HttpClient();

            var response = await client.GetAsync(new ApiSettings().BuildPath("/"));

            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public async void ApiAcess_ValidKey_UnauthorizedStatusCode()
        {
            var client = new HttpClient();

            var response = await client.GetAsync(new ApiSettings().BuildPath("/", "nope"));

            Assert.False(response.IsSuccessStatusCode);
        }
    }
}
