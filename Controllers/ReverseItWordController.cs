using FiveToSeven___Endpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItWordController : ControllerBase
    {
        private readonly ReverseItWordService _reverseItWordService;
        public ReverseItWordController(ReverseItWordService reverseItWordService)
        {
            _reverseItWordService = reverseItWordService;
        }
        [HttpGet("{input}")]
        public string ReverseWord(string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                return "Input cannot be empty.";
            }
            var reversed = _reverseItWordService.ReverseWord(input);
            return $"You entered {input}, reversed is {reversed}";

        }
    }
}