using Mission10_back_.DTOs;

namespace Mission10_back_.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<BowlerWithTeamDTO> GetAllBowlersWithTeams();

    }
}
