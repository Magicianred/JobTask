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
        /// <summary>
        /// if request is available then response 
        /// return true
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// todo some comment
        /// </summary>
        [JsonPropertyName("errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// todo: some comment
        /// </summary>
        [JsonPropertyName("errorDescription")]
        public string ErrorDescription { get; set; }
    }
}
