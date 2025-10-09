using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq.Expressions;

namespace DBconnector
{
    public class Class1 : IDBConnector
    {
        private readonly IMongoClient _client;

        public Class1(string connectionString)
        {
            _client = new MongoClient(connectionString);
        }

        public async Task<bool> Ping()
        {
            try
            {
                var database = _client.GetDatabase("admin");

                var command = new BsonDocument { { "ping", 1 } };

                await _client.GetDatabase("admin").RunCommandAsync<BsonDocument>(command);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}


       


