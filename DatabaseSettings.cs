using System.Collections.Generic;

namespace cosmosdata
{
    public class DatabaseSettings
    {
        public string DatabaseName { get; set; }

        public string CollectionName { get; set; }

        public List<DatabaseAccessSettings> Locations { get; set; }

    }

    public class DatabaseAccessSettings
    {
        public string PRIMARY_ENDPOINT { get; set; }

        public string SECONDARY_ENDPOINT { get; set; }

        public string PRIMARY_KEY { get; set; }

        public string SECONDARY_KEY { get; set; }

        public List<string> SECONDARY_LOCATIONS { get; set; }

        public List<string> PRIMARY_LOCATIONS { get; set; }
    }
}
