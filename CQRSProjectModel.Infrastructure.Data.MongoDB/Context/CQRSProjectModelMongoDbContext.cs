using MongoDB.Driver;

namespace CQRSProjectModel.Infrastructure.Data.MongoDB.Context
{
    public class CQRSProjectModelMongoDbContext
    {
        public IMongoDatabase mongoDatabase { get; }

        public CQRSProjectModelMongoDbContext()
        {
            var client = new MongoClient("mongodb://admin:v123456@ds149146.mlab.com:49146/CQRSProjectModel");

            mongoDatabase = client.GetDatabase("CQRSProjectModel");
        }
    }
}
