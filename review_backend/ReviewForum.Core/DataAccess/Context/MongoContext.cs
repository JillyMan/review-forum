using System;
using MongoDB.Driver;
using ReviewForum.Core.Settings;
using ReviewForum.Core.DataAccess.Interfaces;
using Microsoft.Extensions.Options;

namespace ReviewForum.Core.DataAccess.Context
{
    public class MongoContext : IMongoContext
    {
        private readonly MongoSettings _settings;

        private readonly IMongoDatabase _database;

        public MongoContext(IOptions<MongoSettings> option)
        {
            _settings = option.Value;
            MongoDB.Bson.BsonDefaults.GuidRepresentation = MongoDB.Bson.GuidRepresentation.CSharpLegacy;
            var client = new MongoClient(_settings.ConnectionString);
            _database = client.GetDatabase(_settings.DatabaseName);
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {

            var collectionName = _settings.CollectionNames.TryGetValue(name, out var result) ? result : throw new ArgumentException($"{name} does not exist in Db collection");
            return _database.GetCollection<T>(collectionName);
        }
    }
}