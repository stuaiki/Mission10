//This is EF file
namespace APIBowlers.Models
{
    // inherite from IBowlerRepository
    public class EFBowlerRepository : IBowlerRepository
    {
        // create _bowlerContext to access to data
        private BowlingLeagueContext _bowlerContext;
        public EFBowlerRepository(BowlingLeagueContext temp)
        {
            _bowlerContext = temp;
        }
        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;

        // create function to access to joined data. Use object because we want to access both bowler and team
        public IEnumerable<object> GetAllBowlersWithTeams()
        {
            var joinData = from bowler in _bowlerContext.Bowlers
                           join team in _bowlerContext.Teams
                           on bowler.TeamId equals team.TeamId
                           where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                           select new
                           {
                               BowlerId = bowler.BowlerId,
                               BowlerLastName = bowler.BowlerLastName,
                               BowlerFirstName = bowler.BowlerFirstName,
                               BowlerMiddleInit = bowler.BowlerMiddleInit,
                               BowlerAddress = bowler.BowlerAddress,
                               BowlerCity = bowler.BowlerCity,
                               BowlerState = bowler.BowlerState,
                               BowlerZip = bowler.BowlerZip,
                               BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                               TeamId = team.TeamId,
                               TeamName = team.TeamName,
                               CaptainId = team.CaptainId
                           };

            var BowlersWithTeams = joinData.ToList();

            return BowlersWithTeams;
        }
    }
}
