using DBconnector;
using System;
using static DBconnector.IDBConnector;
using static DBconnector.Class1;
using static DBconnector.PostgresConnector;
class Program
{
    static async Task Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select DB (mongo/postgres) or type 'exit':");
            var db = Console.ReadLine()?.Trim().ToLower();

            if (db == "exit") break;

            Console.WriteLine("Enter connection string:");
            var connectionString = Console.ReadLine() ?? string.Empty;

            IDBConnector connector = db switch
            {
                "mongo" => new Class1(connectionString),
                "postgres" => new PostgresConnector(),
                _ => null
            };

            if (connector == null)
            {
                Console.WriteLine("Invalid selection.\n");
                continue;
            }

            var success = await connector.Ping();
            Console.WriteLine(success ? "Ping successful!" : "Ping failed.");
            Console.WriteLine();
        }
    }
}
