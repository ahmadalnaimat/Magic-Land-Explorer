using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MagicLandExplorer
{
    public class Category
    {
        [JsonProperty("category")]
        public string CategoryName { get; set; }
        [JsonProperty("destinations")]
        public List<Destination> Destinations { get; set; }
    }
}
