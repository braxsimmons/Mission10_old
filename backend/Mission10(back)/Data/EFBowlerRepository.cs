using Microsoft.EntityFrameworkCore;
using Mission10_back_.DTOs;

namespace Mission10_back_.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _BowlingLeagueContext;
        public EFBowlerRepository(BowlingLeagueContext temp) {
            _BowlingLeagueContext = temp;
        }

        IEnumerable<Bowler> IBowlerRepository.Bowlers => _BowlingLeagueContext.Bowlers;
        public IEnumerable<BowlerWithTeamDTO> GetAllBowlersWithTeams()
        {
            var bowlersWithTeams = _BowlingLeagueContext.Bowlers
                .Include(b => b.Team)
                .Select(b => new BowlerWithTeamDTO
                {
                    Id = b.BowlerId,
                    FirstName = b.BowlerFirstName,
                    LastName = b.BowlerLastName,
                    MiddleInitial = b.BowlerMiddleInit,
                    Address = b.BowlerAddress,
                    City = b.BowlerCity,
                    State = b.BowlerState,
                    Zip = b.BowlerZip,
                    PhoneNumber = b.BowlerPhoneNumber,
                    TeamName = b.Team.TeamName
                }).ToList();

            return bowlersWithTeams;
        }
    }
}
