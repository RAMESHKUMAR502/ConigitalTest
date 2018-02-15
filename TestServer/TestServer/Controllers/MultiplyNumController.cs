using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestServer.Model;

namespace TestWebServer.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class MultiplyNumController : Controller
    {
        [HttpGet("{id}")]
        public ResponceDto Get(int id)
        {
          string res =   isMulpileofSevenandnine(id);
          ResponceDto ResponceDto = new ResponceDto();
          if(res != null)
            {
                ResponceDto.Error = false;
                ResponceDto.Results = res;

            }
          else
            {
                ResponceDto.Error = true;
                ResponceDto.message = "Please Enter Correct NUM";
            }
            return ResponceDto;
        }

        public string isMulpileofSevenandnine(int number)
        {
            string ismu = null;

            if (number <= 0)
                return ismu;

            bool ismutipleof7 = number % 7 == 0;
            bool ismutipleof9 = number % 9 == 0;

            if (ismutipleof7 == true && ismutipleof9 == true)
            {
                ismu = "CN";
            }
            else if (ismutipleof7 == true)
            {
                ismu = "C";
            }
            else if (ismutipleof9 == true)
            {
                ismu = "N";
            }
            else
            {
                ismu = number.ToString();
            }


            return ismu;
        }


    }
}