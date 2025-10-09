using DBconnector;
using Xunit;
using System.Threading.Tasks;
namespace PostConnector
{
    public class PostgresConnectorTests
    {
        [Fact]
        public async Task Ping_ShouldReturnTrue_WhenPostgresIsReachable()
        {
            var connector = new PostgresConnector();
            var result = await connector.Ping();
            Assert.True(result);

        }

        [Fact]
        public async Task Ping_ShouldReturnFalse_WhenPostgresIsNotReachable()
        {
            var connector = new PostgresConnector();
            var result = await connector.Ping();
            Assert.False(result);
        }
    }
}