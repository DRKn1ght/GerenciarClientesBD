using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarClientes
{
    class DBManager
    {
        public static IMongoDatabase Database { get; set; }
        static String DataBaseName = "BD2";
        static string conexaoMongoDB = "URI";
        static DBManager()
        {
            var client = new MongoClient(conexaoMongoDB);
            Database = client.GetDatabase(DataBaseName);
        }
    }
}
