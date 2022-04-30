using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KendoTournaments
{
    public class Tournament
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        //public virtual ICollection<Matchup> Matches { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public int AgeLimit { get; set; }

        public bool SexLimit { get; set; }

        public int GradeLimit { get; set; }
    }
}
