using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JobTask.ServiceLayer
{
    public class PensionItemModel
    {
        [JsonPropertyName("pinfl")]
        public long Pinfl { get; set; }

        [JsonPropertyName("activity_type")]
        public int ActivityType { get; set; }
        
        [JsonPropertyName("rate_summa")]
        public decimal RateSumma { get; set; }

    }
}
