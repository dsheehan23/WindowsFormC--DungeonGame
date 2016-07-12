using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Sheehan
{
    public partial class Form1 : Form
    {
       List<Player> GamePlayers = new List<Player>(); // List to store game players
        
        public Form1() // constructor
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // About option in menu, shows what this page is for, entering player names
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the names of the players under the players label.", "About Dungeon!");

        }

        private void name11_TextChanged(object sender, EventArgs e)
        {

        }

        // When the submit button is clicked, player names are added to the list of player objects
        // if they are not blank, this list is passed to the constructor of form 2 and form 2 is called. Form 1 is hidden.
        private void submit_Click(object sender, EventArgs e)
        {
            if (name1.Text != "")
            {
                GamePlayers.Add(new Player(name1.Text));
            }
            if (name2.Text != "")
            {
                GamePlayers.Add(new Player(name2.Text));
            }
            if (name3.Text != "")
            {
                GamePlayers.Add(new Player(name3.Text));
            }
            if (name4.Text != "")
            {
                GamePlayers.Add(new Player(name4.Text));
            }

            Form2 frm = new
            Form2(GamePlayers);
            this.Hide();
            frm.Show();
        }
    }
}
