using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearGames.Games.Domain.Entities
{
    public class Game : Entity
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
    }
}
