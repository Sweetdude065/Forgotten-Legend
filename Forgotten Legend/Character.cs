/*
* Program Name:     Forgotten_Legend
* Programmer:       Samuel Chinchar
* Programmer:       Arthur Hotes
*/
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
    //Pulling info from page to page
    #region
    public partial class Character : Form
    {
        public int selectedCharacter;
        public int passcode;
        public Character()
        {
            InitializeComponent();
        }
        public string NameString
        {
            //hold name value
            set
            {
                Name = value;
            }
        }
        public int Pass
        {
            //hold passcode value
            set
            {
                passcode = value;
            }
        }
        #endregion
        //Character selection buttons
        #region
        private void maleButton1_Click(object sender, EventArgs e)
        {
            //first player
            if (passcode == 0)
            {
                this.Hide();
                selectedCharacter = 1;
                TutCutScene1 aCut = new TutCutScene1();
                aCut.NameString = Name;
                aCut.Character = selectedCharacter;
                aCut.ShowDialog();
                this.Close();
            }
            if (passcode == 1)
            {
                this.Hide();
                selectedCharacter = 1;
                Map1 aMap = new Map1();
                aMap.NameString = Name;
                aMap.Pass = passcode;
                aMap.Character = selectedCharacter;
                aMap.ShowDialog();
                this.Close();
            }
        }

        private void maleButton2_Click(object sender, EventArgs e)
        {
            //second player
            if (passcode == 0)
            {
                this.Hide();
                selectedCharacter = 2;
                TutCutScene1 aCut = new TutCutScene1();
                aCut.NameString = Name;
                aCut.Character = selectedCharacter;
                aCut.ShowDialog();
                this.Close();
            }
            if (passcode == 1)
            {
                this.Hide();
                selectedCharacter = 2;
                Map1 aMap = new Map1();
                aMap.NameString = Name;
                aMap.Pass = passcode;
                aMap.Character = selectedCharacter;
                aMap.ShowDialog();
                this.Close();
            }
        }

        private void femaleButton1_Click(object sender, EventArgs e)
        {
            //third player
            if (passcode == 0)
            {
                this.Hide();
                selectedCharacter = 3;
                TutCutScene1 aCut = new TutCutScene1();
                aCut.NameString = Name;
                aCut.Character = selectedCharacter;
                aCut.ShowDialog();
                this.Close();
            }
            if (passcode == 1)
            {
                this.Hide();
                selectedCharacter = 3;
                Map1 aMap = new Map1();
                aMap.NameString = Name;
                aMap.Pass = passcode;
                aMap.Character = selectedCharacter;
                aMap.ShowDialog();
                this.Close();
            }
        }

        private void iLikeBigButtonsAndICannotLie_Click(object sender, EventArgs e)
        {
            //forth player
            selectedCharacter = 4;
        }

        private void pickTimer_Tick(object sender, EventArgs e)
        {
            //forth player cont.
            if(selectedCharacter == 4)
            {
                if (passcode == 0)
                {   
                        this.Hide();
                        pickTimer.Stop();
                        TutCutScene1 aCut = new TutCutScene1();
                        aCut.NameString = Name;
                        aCut.Character = selectedCharacter;
                        aCut.ShowDialog();
                        this.Close();
                }
                if (passcode == 1)
                {
                    this.Hide();
                    selectedCharacter = 4;
                    Map1 aMap = new Map1();
                    aMap.NameString = Name;
                    aMap.Pass = passcode;
                    aMap.Character = selectedCharacter;
                    aMap.ShowDialog();
                    this.Close();
                }

            }
        }

        private void Character_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
