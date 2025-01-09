using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiveToSeven___Endpoints.Services;
namespace FiveToSeven___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumberController : ControllerBase
    {
        private readonly ReverseItNumberService _reverseItNumberService;
        public ReverseItNumberController(ReverseItNumberService reverseItNumberService)
        {
            _reverseItNumberService = reverseItNumberService;
        }

        [HttpGet("{number}")]
        public string ReverseNumber(string number)
        {

            if (!int.TryParse(number, out int parsedNumber))
            {

                return "Invalid input. Please enter a valid number.";
            }
              return _reverseItNumberService.ReverseNumber(number);
        }
    }
}