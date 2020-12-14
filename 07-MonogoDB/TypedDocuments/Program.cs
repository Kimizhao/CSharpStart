using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace TypedDocuments
{
    class Program
    {
        public class Person
        {
            public ObjectId Id { get; set; }
            public string Name { get; set; }
        }

        async static Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            await test1();
        }

        static async Task test1()
        {
            var client = new MongoClient("mongodb://192.168.10.100:27017");
            var database = client.GetDatabase("foo");
            var collection = database.GetCollection<Person>("bar");

            await collection.InsertOneAsync(new Person { Name = "Kimi" });

            var list = await collection.Find(x => x.Name == "Kimi")
                .ToListAsync();

            foreach (var person in list)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
