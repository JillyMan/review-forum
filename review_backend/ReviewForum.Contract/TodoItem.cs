using System;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace ReviewForum.Contract
{
    public class TodoItem : BaseEntity
    {
        [JsonIgnore]
        public override Guid Id { get; set; } = Guid.NewGuid();

        [BsonElement("_id")]
        [JsonProperty(PropertyName = "Id")]
        public Guid TodoId { get; set; }

        public string Title { get; set; }

        public bool IsComleted { get; set; }
    }
}
