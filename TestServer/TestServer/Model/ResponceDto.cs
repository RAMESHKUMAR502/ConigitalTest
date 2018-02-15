using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestServer.Model
{
    public class ResponceDto
    {
        public string Results { get; set; }
        public bool Error { get; set; }

        public string message { get; set; }
    }
}
