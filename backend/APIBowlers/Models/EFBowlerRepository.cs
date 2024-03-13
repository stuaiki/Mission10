namespace APIBowlers.Models
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _bowlerContext;
        public EFBowlerRepository(BowlingLeagueContext temp)
        {
            _bowlerContext = temp;
        }
        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;

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
