using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Fina.Core.Responses
{
    public class Response<T>
    {
        [JsonConstructor]
        public Response() => 
            _code = Configuration.DefaultStatusCode;
        public Response(T? data, 
            int code=Configuration.DefaultStatusCode,
            string? message=null
            ) 
        { 
        Data = data;
        _code = code;
        Message = message;
        }

        public int _code = Configuration.DefaultStatusCode;
        public T? Data { get; set; }
        public string? Message { get; set; }

        [JsonIgnore]
        public bool _success => _code is >= 200  and <=299;
    }
}

