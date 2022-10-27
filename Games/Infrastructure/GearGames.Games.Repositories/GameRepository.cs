using GearGames.Games.Data.Context;
using GearGames.Games.Domain.Core.Interfaces.Repositories;
using GearGames.Games.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearGames.Games.Repositories
{
    public class GameRepository : BaseRepository<Game>, IGameRepository
    {
        public GameRepository(GameDbContext context) : base(context) { }
    }
}
