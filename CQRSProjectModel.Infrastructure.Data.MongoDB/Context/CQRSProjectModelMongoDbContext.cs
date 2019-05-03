using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System.IO;

namespace CQRSProjectModel.Infrastructure.Data.MongoDB.Context
{
    public class CQRSProjectModelMongoDbContext
    {
        private static readonly string DatabaseName = "cqrsprojectmodel";

        public IMongoDatabase MongoDatabase { get; }

        public CQRSProjectModelMongoDbContext()
        {
            var configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            var client = new MongoClient(configuration.GetConnectionString("ConnectionStringMongoDB"));

            MongoDatabase = client.GetDatabase(DatabaseName);
        }
    }
}
