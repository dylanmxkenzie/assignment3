using MongoDB.Driver;

namespace DBconnector
{
    public class Class1
    {
        private readonly MongoClient _database;

        public DBconnector(string connectionString);
        {
        _database = new MongoClient(connectionString);
    }
}

public bool Ping();
{
    return false;

    try
    {
        var db = _database.GetDatabase("admin");
        var command = new BsonDocument("ping", 1);
        var result = db.RunCommand<BsonDocument>(command);
    }
}