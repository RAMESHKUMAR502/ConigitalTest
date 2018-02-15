using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConigitalTestMobileApp.Model
{
    public class ResponseModelDTO
    {
        public string Results { get; set; }
        public bool Error { get; set; }

        public string message { get; set; }
    }

    public class config
    {
        public static string BaseUrl
        {
            get
            {
                return "http://10.130.177.48:53169/";

            }
        }
    }
}
