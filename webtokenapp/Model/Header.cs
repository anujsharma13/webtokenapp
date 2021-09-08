using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace webtokenapp.Model
{
    public class Header
    {
        public string alg { get; set; } = "HS256";
        public string typ { get; set; } = "JWT";

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
        public string ToBase64String()
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(ToJson()));
        }
    }
}
