using MongoDB.Driver;

namespace vs2015webapi
{
    public static class DBHelper
    {
        /// <summary>
        /// TimelineAppDB on aws
        /// </summary>
        /// <returns></returns>
        public static dynamic ConnectMongoAWS()
        {
            var client = new MongoClient("mongodb.com");
            var database = client.GetDatabase("AppDB");

            return database;
        }
    }
}
