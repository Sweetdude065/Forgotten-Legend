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
    public partial class CutScene1 : Form
    {
        public int selectedCharacter;
        public CutScene1()
        {
            InitializeComponent();
        }
        public int Character

        {

            set

            {

                selectedCharacter = value;

            }
        }
        public string NameString

        {

            set

            {

                Name = value;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //autochat
            timer1.Stop(); richTextBox1.Text += "[???] \n Hello "+ Name + "? \n Are you alive? \n Please Answer! \n ------------------------";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //buttons show up
            timer2.Stop();
            WhoButton.Visible = true;
            WhereButton.Visible = true;
            button3.Visible = true;
            skipButton.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //chat option
            richTextBox1.Text += "\n [" + Name + "] \n Let's get moving. \n ------------------------";
            richTextBox1.Text += "\n [???] \n Good we gotta get out of here before... Oh no. \n ------------------------" + "\n [Monster] \n RAWR!!!!! \n ------------------------";
            button3.Visible = false;
            skipButton.Visible = false;
            WhoButton.Visible = false;
            WhereButton.Visible = false;
            timer3.Start();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //chat option
            timer3.Stop();
            this.Close();
            Fight1 fightForm = new Fight1();
            fightForm.NameString = Name;
            fightForm.Character = selectedCharacter;
            fightForm.ShowDialog();
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            //chat option
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //chat option
            timer4.Stop();
            this.Close();
            Fight1 fightForm = new Fight1();
            fightForm.NameString = Name;
            fightForm.Character = selectedCharacter;
            fightForm.ShowDialog();
            this.Hide();
        }

        private void WhereButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\n [" + Name + "] \n Where am I? \n ------------------------";
            richTextBox1.Text += "\n [???] \n You are in a cave, I suggest we get out of here, and quicky! \n ------------------------";
            WhereButton.Visible = false;
        }

        private void WhoButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\n [" + Name + "] \n Who are you? \n ------------------------";
            richTextBox1.Text += "\n [???] \n You don't remember me? Oh well, we got to get out of here right now! \n ------------------------";
            WhoButton.Visible = false;
        }

        private void CutScene1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // bind this method to its TextChanged event handler:
            // richTextBox.TextChanged += richTextBox_TextChanged;
            // set the current caret position to the end
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }
    }
}
