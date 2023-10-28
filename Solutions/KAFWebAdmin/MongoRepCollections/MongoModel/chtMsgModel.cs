using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KAFWebAdmin.MongoRepCollections.MongoModel
{
    public class chtMsgModel
    {
        [BsonId]
        public ObjectId Id { get; set; } //MongoDb uses this field as identity.
        [Required]
        public string fromUserName { get; set; }
        public string toUserName { get; set; }
        [Required]
        public string msg { get; set; }
        [Required]
        public string msgtype { get; set; } //personal/all
        public string Timestamp { get; set; } 
    }
}