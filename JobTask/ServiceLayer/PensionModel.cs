using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JobTask.ServiceLayer.Pension
{
    public class PensionModel : ErrorResultModel
    {
        [JsonPropertyName("data")]
        public IEnumerable<PensionItemModel> Data { get; set; }
    }
}
