using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq.Expressions;

namespace DBconnector
{
    public class Class1
    {
        private readonly IMongoClient _client;

        public Class1(string connectionString)
        {
            _client = new MongoClient(connectionString);
        }

    public bool Ping()
        {
            try
            {
                var command = new BsonDocument { { "ping", 1 } };

                _client.GetDatabase("admin").RunCommand<BsonDocument>(command);
                return true;
            }
            catch
            {
                return false;
            }

                       


            }
        }
    }



