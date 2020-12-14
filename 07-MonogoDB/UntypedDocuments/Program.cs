using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace UntypedDocuments
{
    class Program
    {
        async static Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            await test1();
        }

        static async Task test1()
        {
            var client = new MongoClient("mongodb://192.168.10.100:27017");
            var database = client.GetDatabase("foo");
            var collection = database.GetCollection<BsonDocument>("bar");

            await collection.InsertOneAsync(new BsonDocument("Name", "Jack"));

            var list = await collection.Find(new BsonDocument("Name", "Jack"))
                .ToListAsync();

            foreach (var document in list)
            {
                Console.WriteLine(document["Name"]);
            }
        }
    }
}
