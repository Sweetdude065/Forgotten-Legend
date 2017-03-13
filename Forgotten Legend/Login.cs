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
                userNameBox.Text += "Legend";
            }
            timer1.Start();
            if(passwordBox.Text == "NewKing")
            {
                passcodeInt = 1;
            }


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            string UserName = userNameBox.Text;
            Character aCharacter = new Character();
            aCharacter.NameString = UserName;
            aCharacter.Pass = passcodeInt;
            aCharacter.ShowDialog();

            this.Close();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aAboutBox = new AboutBox1();
            aAboutBox.ShowDialog();
        }
    }
}
