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
        public void Ping_ShouldReturnTrue_WhenMongoIsReachable()
        {
            var mongoContainer = new TestcontainersBuilder<MongoDbTestcontainer>()
                .WithDatabase(new MongoDbTestcontainerConfiguration())
                .Build();

            mongoContainer.StartAsync().GetAwaiter().GetResult();

            var connector = new Class1(mongoContainer.ConnectionString);

            Assert.True(connector.Ping());

            mongoContainer.DisposeAsync();

        }

        [Fact]
        public void Ping_ShouldReturnFalse_WhenConnectionFails()
        {
            var connector = new Class1("mongodb:// invaild");
            Assert.False(connector.Ping());
        }
    }
}