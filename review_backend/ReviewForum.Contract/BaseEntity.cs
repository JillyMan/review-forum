using System;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace ReviewForum.Contract
{
    public class BaseEntity
    {
        [BsonElement("_id")]
        [JsonProperty(PropertyName = "Id")]
        public virtual Guid Id { get; set; }
    }
}