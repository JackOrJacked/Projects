using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtg
{
    
    public class Identifier
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("set")]
        public string Set { get; set; }
        [JsonProperty("collector_number")]
        public string CollectorNumber { get; set; }
    }
    
}
