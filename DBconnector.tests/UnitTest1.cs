using System.Threading.Tasks;
using Xunit;
using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;
using DotNet.Testcontainers.Configurations;


namespace DBconnector.tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Ping_ShouldReturnTrue_WhenMongoIsReachable()
        {
            var mongoContainer = new TestcontainersBuilder<MongoDbTestcontainer>()
                .WithDatabase(new MongoDbTestcontainerConfiguration())
                .Build();

            await mongoContainer.StartAsync();
                

            var connector = new Class1(mongoContainer.ConnectionString);

            var result = await connector.Ping();

            Assert.True(result);

            await mongoContainer.DisposeAsync();

        }

        [Fact]
        public async Task Ping_ShouldReturnFalse_WhenConnectionFails()
        {
            var connector = new Class1("mongodb:// invaild");

            var result = await connector.Ping();
            Assert.False(result);
        }
    }
}