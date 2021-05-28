using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JobTask.ServiceLayer.Pension
{
    public class PensionTinModel : ErrorResultModel
    {
        /// <summary>
        /// todo: something
        /// </summary>
        [JsonPropertyName("data")]
        public PensionTinItemModel Data { get; set; }
    }

    public class PensionTinItemModel
    {
        /// <summary>
        /// todo: something
        /// </summary>
        [JsonPropertyName("pinfl")]
        public long Pinfl { get; set; }

        /// <summary>
        /// todo: something
        /// </summary>
        [JsonPropertyName("tin")]
        public long Tin { get; set; }
    }
}
