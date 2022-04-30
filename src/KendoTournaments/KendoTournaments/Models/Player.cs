using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KendoTournaments
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int Age { get; set; }

        public int Sex { get; set; }

        public int Grade { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Tournament> Tournaments { get; set; }


    }
}
