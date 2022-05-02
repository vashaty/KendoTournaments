using KendoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KendoTournaments
{
    public partial class CreateTournament : Form
    {
        private KendoDbContext db = new KendoDbContext();
        public CreateTournament()
        {
            InitializeComponent();
        }

        private void CreateTournament_Load(object sender, EventArgs e)
        {
            //foreach (var player in db.Player)
            //{
            //    listViewPlayersAll.Items.Add(player.Name);
            //}
            //dataGridViewPlayers.DataSource = db.Player.ToList();
            foreach (var player in db.Player.Where(p => p.Grade > 2))
            {
                dataGridViewPlayers.Rows.Insert(0, player.Id, player.Name, player.Lastname);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var id = dataGridViewPlayers.Rows[dataGridViewPlayers.CurrentRow.Index].Cells[0].Value;

            dataGridViewPlayersAdded.Rows.Insert(0,db.Player.Find(id).Id, db.Player.Find(id).Name, db.Player.Find(id).Lastname);

            dataGridViewPlayers.Rows.RemoveAt(dataGridViewPlayers.CurrentRow.Index);

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var id = dataGridViewPlayersAdded.Rows[dataGridViewPlayers.CurrentRow.Index].Cells[0].Value;

            dataGridViewPlayers.Rows.Insert(0, db.Player.Find(id).Id, db.Player.Find(id).Name, db.Player.Find(id).Lastname);

            dataGridViewPlayersAdded.Rows.RemoveAt(dataGridViewPlayersAdded.CurrentRow.Index);
        }
    }
}
