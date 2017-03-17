using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forgotten_Legend
{
    public partial class Login : Form
    {
        public int passcodeInt;
        public Login()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            if (userNameBox.Text == "")
            {
                userNameBox.Text = "Legend";
            }
            if(passwordBox.Text == "NewKing")
            {
                passcodeInt = 1;
            }
            string UserName = userNameBox.Text;
            Character character = new Character();
            character.NameString = UserName;
            character.Pass = passcodeInt;
            this.Hide();
            character.ShowDialog();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }
    }
}
