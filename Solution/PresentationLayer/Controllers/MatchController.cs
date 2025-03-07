using ApplicationLayer.Interfaces;
using DomainLayer.Aggregate;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [ApiController]
    [Route("api/matches")]
    public class MatchController : ControllerBase
    {
        private readonly IMatchInformationsService _matchInformationsService;

        public MatchController(IMatchInformationsService matchInformationsService)
        {
            _matchInformationsService = matchInformationsService;
        }

        [HttpGet("last/{teamId}/{nbLast}")]
        public ActionResult<List<MatchPlayed>> GetLastMatchesByTeamId(int teamId, int nbLast)
        {
            var matches = _matchInformationsService.GetLastMatchesByTeamId(nbLast, teamId);

            if (matches == null || matches.Count == 0)
                return NotFound("Aucun match trouvé.");

            return Ok(matches);
        }
    }
}
