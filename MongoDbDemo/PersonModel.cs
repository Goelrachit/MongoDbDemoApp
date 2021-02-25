using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDbDemo
{
    public class PersonModel
    {
        [BsonId] // _id (behind the scenes)
        public Guid Id { get; set; } // If we don't pass an Id, meaning if it's null, MongoDb will create one.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel PrimaryAddress { get; set; }

        [BsonElement("dob")]
        public DateTime DateofBirth { get; set; }
    }
}
