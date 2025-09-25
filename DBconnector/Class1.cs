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
