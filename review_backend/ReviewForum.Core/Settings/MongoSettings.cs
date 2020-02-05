using System.Collections.Generic;

namespace ReviewForum.Core.Settings
{
    public class MongoSettings
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }

        public Dictionary<string, string> CollectionNames { get; set; }
    }
}