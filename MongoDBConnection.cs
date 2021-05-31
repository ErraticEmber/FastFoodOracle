using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace FastFoodOracle
{
    class MongoDBConnection
    {
        private readonly MongoClient dbClient;
        public MongoDBConnection()
        {
            dbClient = new MongoClient("mongodb+srv://application:ox51afLsGCd071iB@fastfoodoraclecluster.2qlbx.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
        }

        public void printAllDBs()
        {
            var dbList = dbClient.ListDatabases().ToList();
            foreach(var db in dbList)
            {
                Console.WriteLine(db);
            }
        }

    }
}
