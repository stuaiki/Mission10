using APIBowlers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//This is bowler controller
namespace APIBowlers.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlingLeagueController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            var BowlerData = _bowlerRepository.GetAllBowlersWithTeams();

            return BowlerData;
        }
    }
}
