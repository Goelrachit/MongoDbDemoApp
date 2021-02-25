﻿using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDbDemo
{
    public class NameModel
    {
        [BsonId] // _id (behind the scenes)
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
