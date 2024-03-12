namespace Mission10_back_.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _BowlingLeagueContext;
        public EFBowlerRepository(BowlingLeagueContext temp) {
            _BowlingLeagueContext = temp;
        }

        IEnumerable<Bowler> IBowlerRepository.Bowlers => _BowlingLeagueContext.Bowlers;
    }
}
