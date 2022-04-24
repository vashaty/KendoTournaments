using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KendoTournaments
{
    public class MatchupPlayerModel
    {
        public PlayerModel Player { get; set; }

        public List<Symbols> Symbols { get; set; }

        public MatchupModel? ParentMatchUp { get; set; }
    }
}
