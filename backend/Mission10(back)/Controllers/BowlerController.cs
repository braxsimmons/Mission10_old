using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_back_.Data;

namespace Mission10_back_.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerController(IBowlerRepository temp) {
            _bowlerRepository=temp;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Bowler>> GetWithTeams()
        {
            var bowlerData = _bowlerRepository.GetAllBowlersWithTeams();
            if (bowlerData == null || !bowlerData.Any())
            {
                return NotFound();
            }
            return Ok(bowlerData);
        }

    }
}
