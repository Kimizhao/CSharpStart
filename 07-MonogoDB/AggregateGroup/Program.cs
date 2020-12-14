using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Linq;

namespace AggregateGroup
{
    class Program
    {
        public class ExampleGroup
        {
            [BsonId]
            public ObjectId Id { get; set; }
            public string SomeStringField { get; set; }
            public int SomeNumberField { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //{ _id: "$SomeStringField", Result: { "$max": "$SomeNumberField" } }
            var client = new MongoClient("mongodb://192.168.10.100:27017");
            var database = client.GetDatabase("foo");
            var collection = database.GetCollection<ExampleGroup>("bar1");

            //collection.InsertOneAsync(new ExampleGroup { SomeStringField = "Kimi", SomeNumberField = 1 });
            //collection.InsertOneAsync(new ExampleGroup { SomeStringField = "Kimi", SomeNumberField = 2 });
            //collection.InsertOneAsync(new ExampleGroup { SomeStringField = "Kimi", SomeNumberField = 3 });
            //collection.InsertOneAsync(new ExampleGroup { SomeStringField = "Jack", SomeNumberField = 1 });
            //collection.InsertOneAsync(new ExampleGroup { SomeStringField = "Jack", SomeNumberField = 2 });
            //collection.InsertOneAsync(new ExampleGroup { SomeStringField = "Jack", SomeNumberField = 5 });

            //var result = collection.Aggregate().Group(
            //                x => x.SomeStringField,
            //                g => new {
            //                    Result = g.Select(
            //                               x => x.SomeNumberField
            //                               ).Max()
            //                }
            //            ).ToList();
            var result = collection.Aggregate().Group(
                x => x.SomeStringField,
                g => new
                {
                    Result = g.Max(x => x.SomeNumberField)
                }
            ).ToList();

            result.ForEach(doc => Console.WriteLine(doc.ToJson()));
        }
    }
}
