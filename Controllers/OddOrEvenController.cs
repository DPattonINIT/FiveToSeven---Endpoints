using FiveToSeven___Endpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenService _oddOrEvenService;

        public OddOrEvenController(OddOrEvenService oddOrEvenService)
        {
            _oddOrEvenService = oddOrEvenService;
        }
        [HttpGet("{number}")]
        public string CheckOddOrEven(int number)
        {
            var result = _oddOrEvenService.CheckOddOrEven(number);
            return result;
        }
    }
}