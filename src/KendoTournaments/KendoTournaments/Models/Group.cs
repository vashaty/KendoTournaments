using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KendoTournaments
{
    public class Group
    {
        public int Id { get; set; }
        public Groups Name { get; set; }

        public Tournament Tournament { get; set; }

        public virtual ICollection<Player> Players { get; set; }

    }
}
