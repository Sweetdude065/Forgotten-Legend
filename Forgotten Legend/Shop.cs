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
    public partial class Shop : Form
    {
        public int gold;
        public int Exp;
        public int playerLevel;
        public int Statpoints;
        public int Popup;
        public int goldTotal;
        public int ExpTotal;
        public int ExpReward;
        public int NewMapLevel;
        public int MapLevel;
        public int SwordOn;
        public int selectedCharacter;

        public int oldBow;
        public int oldHat;
        public int oldShirt;
        public int oldPants;
        public int oldShoes;
        public int oldRing;


        public int oldRingOn, oldShoeOn, oldPantsOn, oldShirtOn, oldHatOn, oldBowOn, brokenWoodenSwordOn;
        public int slashPower, bowPower, defPower, evadePower, freezePower, firePower, bolasPower, PlayerHpInt, PlayerMpInt, strPowerStat, defPowerStat;

        public int MaxHp;
        public int MaxMp;
        public Shop()
        {
            InitializeComponent();
        }
        public string NameString

        {

            set

            {

                Name = value;

            }
        }
        public int Character

        {

            set

            {

                selectedCharacter = value;

            }
        }
        public int Gold
        {

            set

            {

                gold += value;

            }


        }
        public int ExpNum
        {

            set

            {

                Exp += value;

            }


        }
        public int SwordBoost
        {

            set

            {

                SwordOn = value;

            }


        }
        public int MapLvl
        {

            set

            {

                MapLevel = value;

            }


        }
        public int YourLevel
        {

            set

            {

                playerLevel = value;


            }


        }
        public int NewMapLvl
        {
            set

            {

                NewMapLevel = value;

            }
        }
        public int oldBowBought
        {
            set
            {
                oldBow = value;
            }
        }
        public int oldHatBought
        {
            set
            {
                oldHat = value;
            }
        }
        public int oldShirtBought
        {
            set
            {
                oldShirt = value;
            }
        }
        public int oldPantsBought
        {
            set
            {
                oldPants = value;
            }
        }
        public int StrStat
        {
            set
            {
                strPowerStat = value;
            }
        }

        public int DefStat
        {
            set
            {
                defPowerStat = value;
            }
        }
        private void boughtTimer_Tick(object sender, EventArgs e)
        {

            if (oldBow == 1)
            {
                button1.Enabled = false;
                button1.Text = "Bought";
            }
            if (oldHat == 1)
            {
                button2.Enabled = false;
                button2.Text = "Bought";
            }
            if (oldShirt == 1)
            {
                button3.Enabled = false;
                button3.Text = "Bought";
            }
            if (oldPants == 1)
            {
                button8.Enabled = false;
                button8.Text = "Bought";
            }
            if (oldShoes == 1)
            {
                button7.Enabled = false;
                button7.Text = "Bought";
            }
            if (oldRing == 1)
            {
                button6.Enabled = false;
                button6.Text = "Bought";
            }
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            if (gold >= 15)
            {
                button1.Enabled = true;
            }
            if (gold >= 7)
            {
                button2.Enabled = true;
            }
            if (gold >= 20)
            {
                button3.Enabled = true;
            }
            if (gold >= 15)
            {
                button8.Enabled = true;
            }
            if (gold >= 12)
            {
                button7.Enabled = true;
            }
            if (gold >= 99)
            {
                button6.Enabled = true;
            }


        }

        public int oldShoesBought
        {
            set
            {
                oldShoes = value;
            }
        }
        public int oldRingBought
        {
            set
            {
                oldRing = value;
            }
        }
        public int DefencePower
        {
            set
            {
                defPower = value;
            }
        }
        public int playerMpInt
        {
            set
            {
                PlayerMpInt = value;
            }
        }
        public int maxMp
        {
            set
            {
                MaxMp = value;
            }
        }
        //equiped gears
        public int BWSON
        {
            set
            {
                brokenWoodenSwordOn = value;
            }
        }
        public int OHON
        {
            set
            {
                oldHatOn = value;
            }
        }
        public int OSON
        {
            set
            {
                oldShirtOn = value;
            }
        }
        public int OPON
        {
            set
            {
                oldPantsOn = value;
            }
        }
        public int OSEON
        {
            set
            {
                oldShoeOn = value;
            }
        }
        public int ORON
        {
            set
            {
                oldRingOn = value;
            }
        }
        public int OBON
        {
            set
            {
                oldBowOn = value;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            gold -= 15;
            oldBow = 1;
        }

        private void charTimer_Tick(object sender, EventArgs e)
        {
            charTimer.Stop();
            if (selectedCharacter == 1)
            {
                pictureBox1.BackgroundImage = Forgotten_Legend.Properties.Resources.MaleAdvent;
            }
            if (selectedCharacter == 2)
            {
                pictureBox1.BackgroundImage = Forgotten_Legend.Properties.Resources.ElfMaleAdvent;
            }
            if (selectedCharacter == 3)
            {
                pictureBox1.BackgroundImage = Forgotten_Legend.Properties.Resources.FemaleAdvent;
            }
            if (selectedCharacter == 4)
            {
                pictureBox1.BackgroundImage = Forgotten_Legend.Properties.Resources.mage;
            }
        }


        private void constTimer_Tick(object sender, EventArgs e)
        {
            goldlab.Text = gold.ToString();
            if (gold < 15)
            {
                button1.Enabled = false;
            }
            if (gold < 7)
            {
                button2.Enabled = false;
            }
            if (gold < 20)
            {
                button3.Enabled = false;
            }
            if (gold < 15)
            {
                button8.Enabled = false;
            }
            if (gold < 12)
            {
                button7.Enabled = false;
            }
            if (gold < 99)
            {
                button6.Enabled = false;
            }




            if (oldBow == 1)
            {
                button1.Enabled = false;
                button1.Text = "Bought";
            }
            if (oldHat == 1)
            {
                button2.Enabled = false;
                button2.Text = "Bought";
            }
            if (oldShirt == 1)
            {
                button3.Enabled = false;
                button3.Text = "Bought";
            }
            if (oldPants == 1)
            {
                button8.Enabled = false;
                button8.Text = "Bought";
            }
            if (oldShoes == 1)
            {
                button7.Enabled = false;
                button7.Text = "Bought";
            }
            if (oldRing == 1)
            {
                button6.Enabled = false;
                button6.Text = "Bought";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gold -= 7;
            oldHat = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gold -= 75;
            oldRing = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Map1 Map = new Map1();
            Map.StrStat = strPowerStat;
            Map.DefStat = defPowerStat;
            Map.SwordBoost = SwordOn;
            Map.Name = Name;
            Map.ExpNum = Exp;
            Map.Gold = gold;
            Map.MapLvl = MapLevel;
            Map.YourLevel = playerLevel;
            Map.NewMapLvl = NewMapLevel;
            Map.Character = selectedCharacter;
            Map.oldBowBought = oldBow;
            Map.oldHatBought = oldHat;
            Map.oldShirtBought = oldShirt;
            Map.oldPantsBought = oldPants;
            Map.oldShoesBought = oldShoes;
            Map.oldRingBought = oldRing;
            //equiped stuff
            Map.OBON = oldBowOn;
            Map.OHON = oldHatOn;
            Map.OSON = oldShirtOn;
            Map.OPON = oldPantsOn;
            Map.OSEON = oldShoeOn;
            Map.ORON = oldRingOn;
            Map.BWSON = brokenWoodenSwordOn;
            this.TopMost = false;
            this.Hide();
            this.Close();
            Map.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gold -= 20;
            oldShirt = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            gold -= 15;
            oldPants = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gold -= 12;
            oldShoes = 1;
        }
    }
}
