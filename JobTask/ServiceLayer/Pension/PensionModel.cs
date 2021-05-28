using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JobTask.ServiceLayer.Pension
{
    public class PensionModel : ErrorResultModel
    {
        /// <summary>
        /// todo: all of data
        /// </summary>
        [JsonPropertyName("data")]
        public IEnumerable<PensionItemModel> Data { get; set; }
    }

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
