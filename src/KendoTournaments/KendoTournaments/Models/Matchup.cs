using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KendoTournaments
{
    public class Matchup
    {
        public int Id { get; set; }
        //public List<MatchupPlayer> Players { get; set; }

        public Player Winner { get; set; }

        public DateTime Datetime { get; set; }

        public int MatchupRound { get; set; }

        public Group Group { get; set; }

        public bool Overtime { get; set; }
    }
}
