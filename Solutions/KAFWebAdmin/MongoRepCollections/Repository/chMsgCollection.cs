using KAFWebAdmin.MongoRepCollections.MongoModel;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace KAFWebAdmin.MongoRepCollections.Repository
{
    public class chMsgCollection
    {
        public const string connectionString = "mongodb://flip.mongolab.com:53117,flop.mongolab.com:54117/testdb?replicaSet=rs-flip-flop";
        public const int Max = 100;
        public const int WaitTime = 3;

        //Intializes the mongo db repository
        internal MongoDbRepo _repo = new MongoDbRepo(System.Configuration.ConfigurationManager.AppSettings["mongodbcon"], System.Configuration.ConfigurationManager.AppSettings["mongodbrep"]);
        //Defines the collection name used by project
        private const string _collectionName = "chtMsgCollection";
        //Contains all documents inside the collection
        public IMongoCollection<chtMsgModel> Collection;

        //Constructor
        public chMsgCollection()
        {
            this.Collection = _repo.Db.GetCollection<chtMsgModel>(_collectionName);
        }

        /// <summary>
        /// Insert a contract inside the collection
        /// </summary>
        /// <param name="contact">Contract to inser</param>
        public void InsertContact(chtMsgModel contact)
        {
            this.Collection.InsertOneAsync(contact);
        }
        /// <summary>
        /// Selects all documents
        /// </summary>
        /// <returns>List of all contract</returns>
        public List<chtMsgModel> SelectAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }
        /// <summary>
        /// Get a contract by id
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>returned contracts</returns>
        public chtMsgModel Get(string id)
        {
            return this.Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
        public List<chtMsgModel> GetByFromUserName(string fromUserName)
        {
            return this.Collection.Find(new BsonDocument { { "fromUserName", fromUserName } }).ToListAsync().Result;
        }

        public async Task<List<chtMsgModel>> GetMSGForReConnect(string forUserName)
        {

            var builder = Builders<chtMsgModel>.Filter;
            var filter =
               builder.Or(
                   Builders<chtMsgModel>.Filter.Eq("fromUserName", forUserName)
                   ,Builders<chtMsgModel>.Filter.Eq("toUserName", forUserName)
                   ,Builders<chtMsgModel>.Filter.Eq("toUserName", "all")
                   );

            List<chtMsgModel>  objList = this.Collection.Find(filter).ToListAsync().Result;
            await Task.Delay(1).ConfigureAwait(true);
            return objList;
        }
        
        /// <summary>
        /// Updates an contract
        /// </summary>
        /// <param name="id">Id of contract to update</param>
        /// <param name="contact">Updated informations</param>
        public void UpdateContact(string id, chtMsgModel contact)
        {
            contact.Id = new ObjectId(id);

            var filter = Builders<chtMsgModel>.Filter.Eq(s => s.Id, contact.Id);
            this.Collection.ReplaceOneAsync(filter, contact);
        }
    }
}