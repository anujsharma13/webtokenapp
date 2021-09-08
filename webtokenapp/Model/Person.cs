using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace webtokenapp.Model
{
    public class Person
    {
        public string username { get; set; }
        public string password { get; set; }
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
