using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KAFWebAdmin.MongoRepCollections.Repository
{
    public class MongoDbRepo
    {
        //The client that manage the connection
        public MongoClient Client;
        //The interface that manage the database
        public IMongoDatabase Db;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url">Mongo server url</param>
        /// <param name="database">Database name</param>
        public MongoDbRepo(string url, string database)
        {
            this.Client = new MongoClient(url);
            //if the database is not exist, creates the database
            this.Db = this.Client.GetDatabase(database);
        }
       
    }
}