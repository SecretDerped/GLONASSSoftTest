using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class RequestData
    {
        public int Id { get; set; }
        public UserStatisticRequest UserData { get; set; }
        public DateTime RequestLocalTime { get; set; }
        public string QueryId { get; set; }
    }
}
