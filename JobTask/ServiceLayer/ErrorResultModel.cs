using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JobTask.ServiceLayer.Pension
{
    public class ErrorResultModel
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        
        [JsonPropertyName("errorCode")]
        public string ErrorCode { get; set; }

        [JsonPropertyName("errorDescription")]
        public string ErrorDescription { get; set; }
    }
}
