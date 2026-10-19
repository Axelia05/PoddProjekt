using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace DAL
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase databas;
        public MongoDbContext()
        {

            var klient = new MongoClient("mongodb+srv://axeliamoberg_db_user:Hej050831@orumongodb.4xaq3qj.mongodb.net/");
                databas = klient.GetDatabase("PoddDb");
        }

        public IMongoCollection<T> GetCollection<T>(string namn) => databas.GetCollection<T>(namn);
    }

}
