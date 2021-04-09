using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGameProjectOOP.Entities.GameEntities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameCategory { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
