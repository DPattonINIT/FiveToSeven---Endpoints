using FiveToSeven___Endpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven___Endpoints.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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


            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return "Input must only contain letters (A-Z, a-z).";
                }
            }
            var reversed = _reverseItWordService.ReverseWord(input);
            return $"You entered {input}, reversed is {reversed}";

        }
    }
}