using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class ErrorResponse
    {
        [JsonProperty( "errorCode")]
        public string ErrorCode { get; internal set; }
        [JsonProperty( "httpStatus")]
        public int HTTPStatus { get; internal set; }
        [JsonProperty( "message")]
        public string Message { get; internal set; }
    }
}
