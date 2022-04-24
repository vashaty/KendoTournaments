using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KendoTournaments
{
    public class TournamentModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<PlayerModel> Players { get; set; } = new List<PlayerModel>();

        public List<MatchupModel> Matches { get; set; } = new List<MatchupModel>();

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public int AgeLimit { get; set; }

        public bool SexLimit { get; set; }

        public int GradeLimit { get; set; }
    }
}
