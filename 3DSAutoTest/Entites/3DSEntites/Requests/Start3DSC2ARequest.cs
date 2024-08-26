using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _3DSAutoTest.Entites._3DSEntites.Requests
{
    public class Start3DSC2ARequest
    {
        [JsonPropertyName("PaReq")]
        public string PaReq { get; set; }
        [JsonPropertyName("MD")]
        public string MD { get; set; }
        [JsonPropertyName("TermUrl")]
        public string TermUrl { get; set; }
    }
}
