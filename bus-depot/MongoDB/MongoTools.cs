using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace bus_depot {
    public class MongoTools {
        private IMongoDatabase db;
        public static bool isConnect = false;
        public static bool isAdmin = false;
        public MongoTools(string connectionString, string databaseName) {
            //Create new database connection
            var client = new MongoClient(connectionString);
            db = client.GetDatabase(databaseName);
            try {
                isConnect = db.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);
            } catch {
                isConnect = false;
            }
        }
        /// <summary>
        /// Insert new document into collection
        /// </summary>
        /// <typeparam name="T">Document data type</typeparam>
        /// <param name="collectionName">Collection name</param>
        /// <param name="document">Document</param>
        public void InsertDocument<T>(string collectionName, T document) {
            var collection = db.GetCollection<T>(collectionName);
            collection.InsertOne(document);
        }
        /// <summary>
        /// Load all documents in collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collectionName"></param>
        /// <returns></returns>
        public List<T> LoadAllDocuments<T>(string collectionName) {
            var collection = db.GetCollection<T>(collectionName);
            return collection.Find(new BsonDocument()).ToList();
        }
        /// <summary>
        /// Load document by Id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collectionName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public T LoadDocumentById<T>(string collectionName, ObjectId id) {
            var collection = db.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("Id", id);
            return collection.Find(filter).First();
        }
        /// <summary>
        /// Update document
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collectionName"></param>
        /// <param name="id"></param>
        /// <param name="document"></param>
        [Obsolete]
        public void UpdateDocument<T>(string collectionName, ObjectId id, T document) {
            var collection = db.GetCollection<T>(collectionName);
            var result = collection.ReplaceOne(
                new BsonDocument("_id", id),
                document,
                new UpdateOptions { IsUpsert = false });
        }

        /// <summary>
        /// Insert document into collection if it does not already exist, or update it if it does
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collectionName"></param>
        /// <param name="id"></param>
        /// <param name="document"></param>
        [Obsolete]
        public void UpsertDocument<T>(string collectionName, ObjectId id, T document) {
            var collection = db.GetCollection<T>(collectionName);
            var result = collection.ReplaceOne(
                new BsonDocument("_id", id),
                document,
                new UpdateOptions { IsUpsert = true });
        }

        /// <summary>
        /// Delete document by Id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collectionName"></param>
        /// <param name="id"></param>
        public void DeleteDocument<T>(string collectionName, ObjectId id) {
            var collection = db.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
    }
}