using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entitites.ErrorModel
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public String? Message { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}