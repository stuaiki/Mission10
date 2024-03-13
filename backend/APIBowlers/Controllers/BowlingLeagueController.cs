using APIBowlers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//This is bowler controller
namespace APIBowlers.Controllers
{
    //Route to access to API
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        //private to pull data from dataset
        private IBowlerRepository _bowlerRepository;
        public BowlingLeagueController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        //default
        [HttpGet]
        //use object because we need to pull data from both bowler and team
        public IEnumerable<object> Get()
        {
            //call function to get data
            var BowlerData = _bowlerRepository.GetAllBowlersWithTeams();

            return BowlerData;
        }
    }
}
