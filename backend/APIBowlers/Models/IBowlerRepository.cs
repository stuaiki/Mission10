namespace APIBowlers.Models
{
    //public interface IBowlerRepository
    //{
        //IEnumerable<Bowler> Bowlers { get; }
    //}

    public interface IBowlerRepository
    {
        IEnumerable<object> GetAllBowlersWithTeams();
    }
}
