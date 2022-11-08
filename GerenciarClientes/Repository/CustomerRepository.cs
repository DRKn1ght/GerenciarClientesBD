using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GerenciarClientes.Repository
{
    class CustomerRepository
    {
        private static IMongoCollection<Customer> collection;
        static CustomerRepository()
        {
            collection = DBManager.Database.GetCollection<Customer>("customers");
        }
        public static List<Customer> GetAll()
        {
            var filter = Builders<Customer>.Filter.Empty;
            var customers = collection.Find<Customer>(filter).ToList();
            return customers;
        }

        public static void Insert(Customer customer)
        {
            collection.InsertOne(customer);
        }

        public static Customer GetByCPF(string CPF)
        {
            var filter = Builders<Customer>.Filter;
            Customer customer = collection.Find(filter.Eq("CPF", CPF)).FirstOrDefault();
            return customer;
        }
        public static List<Customer> GetAnyByName(string Name)
        {
            var filter = Builders<Customer>.Filter;
            var customer = collection.Find(filter.Regex("Name", new BsonRegularExpression($".*{Name}.*", options:"i"))).ToList();
            return customer;
        }

        public static List<Customer> GetAnyByCPF(string CPF)
        {
            var filter = Builders<Customer>.Filter;
            var customer = collection.Find(filter.Regex("CPF", new BsonRegularExpression($".*{CPF}.*"))).ToList();
            return customer;
        }

        public static void Update(string CPF, Customer newCustomer)
        {
            var filter = Builders<Customer>.Filter.Eq("CPF", CPF);
            collection.ReplaceOne(filter, newCustomer);
        }

        public static void Delete(string CPF)
        {
            var filter = Builders<Customer>.Filter.Eq("CPF", CPF);
            collection.DeleteOne(filter);
        }
    }
}
