using FiveToSeven___Endpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly MadLibService _madLibService;

        public MadLibController(MadLibService madLibService)
        {
            _madLibService = madLibService;
        }

        [HttpPost("generate/{noun1}/{noun2}/{noun3}/{noun4}/{noun5}/{adjective1}/{adjective2}/{adjective3}/{adjective4}/{adjective5}")]
    public string GenerateStory(
        string noun1, string noun2, string noun3, string noun4, string noun5, 
        string adjective1, string adjective2, string adjective3, string adjective4, string adjective5)
    {
        _madLibService.AddNoun(noun1);
        _madLibService.AddNoun(noun2);
        _madLibService.AddNoun(noun3);
        _madLibService.AddNoun(noun4);
        _madLibService.AddNoun(noun5);

        _madLibService.AddAdjective(adjective1);
        _madLibService.AddAdjective(adjective2);
        _madLibService.AddAdjective(adjective3);
        _madLibService.AddAdjective(adjective4);
        _madLibService.AddAdjective(adjective5);

        var story = _madLibService.UserStory();
        return story;
    }
}
}