using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KendoTournaments
{
    public class MatchupPlayer
    {
        public int Id { get; set; }
        public Player Player { get; set; }

        public virtual ICollection<Symbols> Symbols { get; set; }

        public Matchup ParentMatchUp { get; set; }
        public Matchup MatchUp { get; set; }
    }
}
