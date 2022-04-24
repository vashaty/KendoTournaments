using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KendoTournaments
{
    public class MatchupModel
    {
        public int Id { get; set; }
        public List<MatchupPlayerModel> Players { get; set; }

        public PlayerModel Winner { get; set; }

        public DateTime Datetime { get; set; }

        public int MatchupRound { get; set; }

        public GroupModel Group { get; set; }

        public bool Overtime { get; set; }
    }
}
