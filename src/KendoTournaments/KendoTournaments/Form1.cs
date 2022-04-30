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
    public partial class Form1 : Form
    {
        private KendoDbContext db = new KendoDbContext();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            var player = new Player
            {
                Name = textBoxName.Text,
                Lastname = textBoxLastName.Text,
                Email = textBoxEmail.Text,
                Phone = textBoxPhone.Text,
                Age = (int)numericAge.Value,
                Sex = comboBoxSex.SelectedIndex,
                Grade = comboBoxGrade.SelectedIndex

            };
            db.Player.Add(player);
            db.SaveChanges();
            dataGridViewPlayers.DataSource = db.Player.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] grades = { "7. kjú", "6. kjú" , "5. kjú" , "4. kjú" , "3. kjú" , "2. kjú" , "1. kjú", "1.dan" , "2.dan" , "3.dan" ,
                                "4.dan" , "5.dan" , "6.dan" , "7.dan" , "8.dan" , "9.dan" , "10.dan" };

            dataGridViewPlayers.DataSource = db.Player.ToList();
            comboBoxSex.DataSource = Enum.GetValues(typeof(Sex));
            comboBoxGrade.DataSource = grades;
        }

        private void dataGridViewPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var id = dataGridViewPlayers.Rows[dataGridViewPlayers.CurrentRow.Index].Cells[0].Value;
            db.Player.Remove(db.Player.Find(id));
            db.SaveChanges();
            dataGridViewPlayers.DataSource = db.Player.ToList();
        }

        private void dataGridViewPlayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGridViewPlayers.Rows[e.RowIndex].Cells[0].Value;
            var player = db.Player.Find(id);
            textBoxId.Text = player.Id.ToString();
            textBoxName.Text = player.Name;
            textBoxLastName.Text = player.Lastname;
            textBoxEmail.Text = player.Email;
            textBoxPhone.Text = player.Phone;
            numericAge.Value = player.Age;
            comboBoxGrade.SelectedIndex = player.Grade;
            comboBoxSex.SelectedIndex = player.Sex;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var player = db.Player.Find(int.Parse(textBoxId.Text));
            player.Name = textBoxName.Text;
            player.Lastname = textBoxLastName.Text;
            player.Email = textBoxEmail.Text;
            player.Phone = textBoxPhone.Text;
            player.Age = (int)numericAge.Value;
            player.Grade = comboBoxGrade.SelectedIndex;
            player.Sex = comboBoxSex.SelectedIndex;
            db.SaveChanges();
            dataGridViewPlayers.DataSource = db.Player.ToList();

        }
    }
}
