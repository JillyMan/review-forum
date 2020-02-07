using System;
using System.Collections;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace ReviewForum.Contract
{
    public class ThingItem : BaseEntity
    {
        public float Rate { get; set; }

        public string Type { get; set; }
        
        public string Description { get; set; }

        private List<CommentInfo> Comments { get; set; }
    }
}
