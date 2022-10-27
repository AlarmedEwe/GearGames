using GearGames.Games.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GearGames.Games.API.Controllers
{
    [ApiController]
    [Route("v1/game")]
    public class GameController : ControllerBase
    {
        [HttpGet("todos")]
        public List<Game> Get()
        {
            return new List<Game>();
        }
    }
}
