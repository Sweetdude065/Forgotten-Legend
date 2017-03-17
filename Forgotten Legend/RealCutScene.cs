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
    public partial class RealCutScene : Form
    {
        public int selectedCharacter;
        public int NewMapLevel;
        public RealCutScene()
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

        public int NewMapLvl
        {
            set
            {
                NewMapLevel = value;
            }
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RealCutScene_Load(object sender, EventArgs e)
        {
            skipButton.Visible = true;
            if (NewMapLevel == 1)
            {
                richTextBox1.Text += "[???] \n You are a natural born fighter... Like you always were. \n ------------------------";
                timer1.Start();
            }
            if (NewMapLevel == 3)
            {
                richTextBox1.Text += "[Taylor] \n I must ask you, you don't remember anything? \n ------------------------";
                talkButton1.Text = "Yes";
                talkButton2.Text = "No";
                talkButton1.Visible = true;
                talkButton2.Visible = true;
            }
            if (NewMapLevel == 4)
            {
                richTextBox1.Text += "[Action] \n You stumble uppon a giant sleeping slime. \n ------------------------";
                talkButton1.Text = "Ask Taylor about it";
                talkButton2.Text = "Poke it";
                talkButton1.Visible = true;
                talkButton2.Visible = true;
            }
        }

        private void talkButton1_Click(object sender, EventArgs e)
        {
            if (NewMapLevel == 1)
            {
                richTextBox1.Text += "\n [" + Name + "] \n What is your name? \n ------------------------";
            richTextBox1.Text += "\n [Taylor] \n Sorry I didn't tell you earlier, my name is Taylor. \n ------------------------";
            talkButton1o2.Visible = true;
            talkButton2.Visible = true;
            talkButton3.Visible = true;
            talkButton4.Visible = true;
            talkButton1.Visible = false;
        }
            if (NewMapLevel == 3)
            {
                richTextBox1.Text += "\n [" + Name + "] \n Yeah, I don't. \n ------------------------";
                richTextBox1.Text += "\n [Taylor] \n Okay, I should probably tell you this then... \n ------------------------";
                talkButton1.Visible = false;
                talkButton1o2.Text = "Tell me what?";
                talkButton1o2.Visible = true;
            }
            }

        private void talkButton1o2_Click(object sender, EventArgs e)
        {
            if (NewMapLevel == 1)
            {
                talkButton1o2.Visible = false;
                richTextBox1.Text += "\n [" + Name + "] \n Nice name, I like it. \n ------------------------";
                richTextBox1.Text += "\n [Taylor] \n Thank you, yours isn't bad itself. \n ------------------------";
            }
            if(NewMapLevel == 3)
            {
                richTextBox1.Text += "\n [" + Name + "] \n Keep going. \n ------------------------";
                richTextBox1.Text += "\n [Taylor] \n Well, while we were traveling on our plane this one pers- Ahhh! \n ------------------------";
                richTextBox1.Text += "\n [Action] \n Taylor Slips down a hole, you grab Taylor's hand at the last second. \n ------------------------";
                richTextBox1.Text += "\n [Action] \n Taylor is very shaken up, you decide it's best to finish the conversation later. \n ------------------------";

                talkButton1o2.Visible = false;
            }
        }
        private void talkButton2_Click(object sender, EventArgs e)
        {
            if (NewMapLevel == 1)
            {
                talkButton2.Visible = false;
                richTextBox1.Text += "\n [" + Name + "] \n I was a fighter? \n ------------------------";
                richTextBox1.Text += "\n [Taylor] \n Yes, you were I'll tell you more once we get \n ------------------------";
            }
            if (NewMapLevel == 3)
            {
                richTextBox1.Text += "\n [" + Name + "] \n Nope I remember everything! \n ------------------------";
                richTextBox1.Text += "\n [Taylor] \n Oh? Well then let's keep going shall we. \n ------------------------";
                talkButton2.Visible = false;
                timer1.Interval = 2500;
                timer1.Start();
            }
            if (NewMapLevel == 4)
            {
                richTextBox1.Text += "\n [Action] \n You're a idiot... but you poke the slime anyways. \n ------------------------";
                richTextBox1.Text += "\n [Taylor] \n Stop that, you'll wake it up. \n ------------------------";
            }
        }

        private void talkButton3_Click(object sender, EventArgs e)
        {
            if (NewMapLevel == 1)
            {
                talkButton3.Visible = false;
                richTextBox1.Text += "\n [" + Name + "] \n You found me, do you know what am I doing here? \n ------------------------";
                richTextBox1.Text += "\n [Taylor] \n It's complicated, you will find out sooner or later though. \n ------------------------";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            timer1.Stop();
            if (NewMapLevel == 1)
            {
                richTextBox1.Text += "\n [Action] \n As you're trying to find your way around the cave you decide to ask the stranger some questions \n ------------------------";
                talkButton1.Visible = true;
            }
            if (NewMapLevel == 3)
            {
                this.Close();
            }
        }

        private void talkButton4_Click(object sender, EventArgs e)
        {
            if (NewMapLevel == 1)
            {
                richTextBox1.Text += "\n [" + Name + "] \n Do you think you can assist me while I fight? \n ------------------------";
                richTextBox1.Text += "\n [Action] \n You notice there is a nasty wound on Taylor's arm, you feel bad for asking \n ------------------------";
                talkButton4.Visible = false;
            }
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
