using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KendoTournaments
{
    public partial class GroupModel
    {
        public Groups Name { get; set; }

        public TournamentModel Tournament { get; set; }

        public List<PlayerModel> Players { get; set; }
    }
}
