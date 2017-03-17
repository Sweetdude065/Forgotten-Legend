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
    public partial class Map1 : Form
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
        RealFight RFight = null;
        int MapLevel;
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
        //passcode
        public int password;
        public Map1()
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
        public int NewMapLvl
        {
           set
            {
                NewMapLevel = value;
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

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            AboutBox1 aAboutBox = new AboutBox1();
            aAboutBox.Name = Name;
            aAboutBox.ShowDialog();

        }

        private void cheatCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "GimmieDatCash")
            {
                gold += 999;
            }
            if (textBox1.Text == "LetItRainCum")
            {
                Exp += 1000000;
            }
        }

        private void MysteryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MysteryRadioButton.Checked == true)
            {
                textBox1.Text = "Caution";
            }

            else
            {
                textBox1.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.Close();
            StatusForm Stutus = new StatusForm();
            MapLevel = 1;
            Stutus.playerMpInt = PlayerMpInt;
            Stutus.maxMp = MaxMp;
            Stutus.DefencePower = defPower;
            Stutus.SwordBoost = SwordOn;
            Stutus.Name = Name;
            Stutus.StrStat = strPowerStat;
            Stutus.DefStat = defPowerStat;
            Stutus.ExpNum = Exp;
            Stutus.Gold = gold;
            Stutus.MapLvl = MapLevel;
            Stutus.NewMapLvl = NewMapLevel;
            Stutus.YourLevel = playerLevel;
            Stutus.oldBowBought = oldBow;
            Stutus.oldHatBought = oldHat;
            Stutus.oldShirtBought = oldShirt;
            Stutus.oldPantsBought = oldPants;
            Stutus.oldShoesBought = oldShoes;
            Stutus.oldRingBought = oldRing;
            Stutus.Character = selectedCharacter;
            //Equip
            Stutus.OBON = oldBowOn;
            Stutus.OHON = oldHatOn;
            Stutus.OSON = oldShirtOn;
            Stutus.OPON = oldPantsOn;
            Stutus.OSEON = oldShoeOn;
            Stutus.ORON = oldRingOn;
            Stutus.BWSON = brokenWoodenSwordOn;
            this.Close();
            Stutus.ShowDialog();
        }

        private void updaterTimer_Tick(object sender, EventArgs e)
        {
           
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
        //passcode
        public int Pass
        {
            set
            {
                password = value;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Map1_Load(object sender, EventArgs e)
        {
            if(password == 1)
            {
                Exp = 16000;
                gold = 25;
                NewMapLevel = 4;
                //items on
                oldBowOn = 1;
                oldHatOn = 1;
                oldPantsOn = 1;
                oldRingOn = 1;
                oldShirtOn = 1;
                oldShoeOn = 1;
                //items bought
                oldBow = 1;
                oldHat = 1;
                oldPants = 1;
                oldRing = 1;
                oldShirt = 1;
                oldShoes = 1;


            }
            ExpLabel.Text = Exp.ToString() + "/1000";
            Goldlabel.Text = gold.ToString();
            nameLabel.Text = Name;
            if (Exp < 999)
            {
                label4.Visible = true;
            }
            if (Exp > 999)
            {
                label4.Visible = false;
            }
            if (NewMapLevel == 1)
            {
                radioButton2.Visible = true;
                lineShape1.Visible = true;
                lineShape25.Visible = true;
                CaveradioButton26.Visible = true;
                MysteryRadioButton.Visible = true;
                MLineShape.Visible = true;
            }
            if (NewMapLevel == 2)
            {
                radioButton2.Visible = true;
                lineShape1.Visible = true;
                lineShape25.Visible = true;
                CaveradioButton26.Visible = true;
                MysteryRadioButton.Visible = true;
                MLineShape.Visible = true;
                lineShape2.Visible = true;
                radioButton3.Visible = true;
            }
            if (NewMapLevel == 3)
            {
                radioButton2.Visible = true;
                lineShape1.Visible = true;
                lineShape25.Visible = true;
                CaveradioButton26.Visible = true;
                MysteryRadioButton.Visible = true;
                MLineShape.Visible = true;
                lineShape2.Visible = true;
                radioButton3.Visible = true;
                lineShape3.Visible = true;
                radioButton4.Visible = true;
            }
            if (NewMapLevel == 4)
            {
                radioButton2.Visible = true;
                lineShape1.Visible = true;
                lineShape25.Visible = true;
                CaveradioButton26.Visible = true;
                MysteryRadioButton.Visible = true;
                MLineShape.Visible = true;
                lineShape2.Visible = true;
                radioButton3.Visible = true;
                lineShape3.Visible = true;
                radioButton4.Visible = true;
                lineShape10.Visible = true;
                radioButton5.Visible = true;

            }
            if (Exp <= 999)
            {
                playerLevel = 1;
                ExpLabel.Text = Exp.ToString() + "/1000";
            }
            if (Exp >= 1000)
            {
                playerLevel = 2;
                ExpLabel.Text = Exp.ToString() + "/2000";
            }
            if (Exp >= 2000)
            {
                playerLevel = 3;
                ExpLabel.Text = Exp.ToString() + "/4000";
            }
            if (Exp >= 4000)
            {
                playerLevel = 4;
                ExpLabel.Text = Exp.ToString() + "/8000";
            }
            if (Exp >= 8000)
            {
                playerLevel = 5;
                ExpLabel.Text = Exp.ToString() + "/16000";
            }
            if (Exp >= 16000)
            {
                playerLevel = 6;
                ExpLabel.Text = Exp.ToString() + "/32000";
            }
            if (Exp >= 32000)
            {
                playerLevel = 7;
                ExpLabel.Text = Exp.ToString() + "/64000";
            }
            if (Exp >= 64000)
            {
                playerLevel = 8;
                ExpLabel.Text = Exp.ToString() + "/128000";
            }
            if (Exp >= 128000)
            {
                playerLevel = 9;
                ExpLabel.Text = Exp.ToString() + "/256000";
            }
            if (Exp >= 256000)
            {
                playerLevel = 10;
                ExpLabel.Text = Exp.ToString() + "/512000";
            }
            if (Exp >= 512000)
            {
                playerLevel = 11;
                ExpLabel.Text = Exp.ToString() + "/1024000";
            }
            if (Exp >= 1024000)
            {
                playerLevel = 12;
                ExpLabel.Text = Exp.ToString() + "/Unknown";
            }
            Level.Text = playerLevel.ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.TopMost = false;
                RFight = new RealFight();
                MapLevel = 1;
                RFight.playerMpInt = PlayerMpInt;
                RFight.maxMp = MaxMp;
                RFight.DefencePower = defPower;
                RFight.SwordBoost = SwordOn;
                RFight.Name = Name;
                RFight.StrStat = strPowerStat;
                RFight.DefStat = defPowerStat;
                RFight.ExpNum = Exp;
                RFight.Gold = gold;
                RFight.MapLvl = MapLevel;
                RFight.NewMapLvl = NewMapLevel;
                RFight.YourLevel = playerLevel;
                RFight.oldBowBought = oldBow;
                RFight.oldHatBought = oldHat;
                RFight.oldShirtBought = oldShirt;
                RFight.oldPantsBought = oldPants;
                RFight.oldShoesBought = oldShoes;
                RFight.oldRingBought = oldRing;
                RFight.Character = selectedCharacter;
                //Equip
                RFight.OBON = oldBowOn;
                RFight.OHON = oldHatOn;
                RFight.OSON = oldShirtOn;
                RFight.OPON = oldPantsOn;
                RFight.OSEON = oldShoeOn;
                RFight.ORON = oldRingOn;
                RFight.BWSON = brokenWoodenSwordOn;
                RFight.ShowDialog();
                this.Close();

            }
            if(radioButton2.Checked == true)
            {
                this.TopMost = false;
                RFight = new RealFight();
                MapLevel = 2;
                RFight.playerMpInt = PlayerMpInt;
                RFight.maxMp = MaxMp;
                RFight.DefencePower = defPower;
                RFight.SwordBoost = SwordOn;
                RFight.Name = Name;
                RFight.ExpNum = Exp;
                RFight.Gold = gold;
                RFight.StrStat = strPowerStat;
                RFight.DefStat = defPowerStat;
                RFight.MapLvl = MapLevel;
                RFight.NewMapLvl = NewMapLevel;
                RFight.YourLevel = playerLevel;
                RFight.oldBowBought = oldBow;
                RFight.oldHatBought = oldHat;
                RFight.oldShirtBought = oldShirt;
                RFight.oldPantsBought = oldPants;
                RFight.oldShoesBought = oldShoes;
                RFight.oldRingBought = oldRing;
                RFight.Character = selectedCharacter;
                //Equip
                RFight.OBON = oldBowOn;
                RFight.OHON = oldHatOn;
                RFight.OSON = oldShirtOn;
                RFight.OPON = oldPantsOn;
                RFight.OSEON = oldShoeOn;
                RFight.ORON = oldRingOn;
                RFight.BWSON = brokenWoodenSwordOn;
                RFight.ShowDialog();
                this.Close();
            }
            if (radioButton3.Checked == true)
            {
                this.TopMost = false;
                RFight = new RealFight();
                MapLevel = 3;
                RFight.playerMpInt = PlayerMpInt;
                RFight.maxMp = MaxMp;
                RFight.DefencePower = defPower;
                RFight.SwordBoost = SwordOn;
                RFight.Name = Name;
                RFight.ExpNum = Exp;
                RFight.Gold = gold;
                RFight.StrStat = strPowerStat;
                RFight.DefStat = defPowerStat;
                RFight.MapLvl = MapLevel;
                RFight.NewMapLvl = NewMapLevel;
                RFight.YourLevel = playerLevel;
                RFight.oldBowBought = oldBow;
                RFight.oldHatBought = oldHat;
                RFight.oldShirtBought = oldShirt;
                RFight.oldPantsBought = oldPants;
                RFight.oldShoesBought = oldShoes;
                RFight.oldRingBought = oldRing;
                RFight.Character = selectedCharacter;
                //Equip
                RFight.OBON = oldBowOn;
                RFight.OHON = oldHatOn;
                RFight.OSON = oldShirtOn;
                RFight.OPON = oldPantsOn;
                RFight.OSEON = oldShoeOn;
                RFight.ORON = oldRingOn;
                RFight.BWSON = brokenWoodenSwordOn;
                RFight.ShowDialog();
                this.Close();
            }
            if (radioButton4.Checked == true)
            {
                this.TopMost = false;
                RFight = new RealFight();
                MapLevel = 4;
                RFight.playerMpInt = PlayerMpInt;
                RFight.maxMp = MaxMp;
                RFight.DefencePower = defPower;
                RFight.SwordBoost = SwordOn;
                RFight.Name = Name;
                RFight.ExpNum = Exp;
                RFight.Gold = gold;
                RFight.StrStat = strPowerStat;
                RFight.DefStat = defPowerStat;
                RFight.MapLvl = MapLevel;
                RFight.NewMapLvl = NewMapLevel;
                RFight.YourLevel = playerLevel;
                RFight.oldBowBought = oldBow;
                RFight.oldHatBought = oldHat;
                RFight.oldShirtBought = oldShirt;
                RFight.oldPantsBought = oldPants;
                RFight.oldShoesBought = oldShoes;
                RFight.oldRingBought = oldRing;
                RFight.Character = selectedCharacter;
                //Equip
                RFight.OBON = oldBowOn;
                RFight.OHON = oldHatOn;
                RFight.OSON = oldShirtOn;
                RFight.OPON = oldPantsOn;
                RFight.OSEON = oldShoeOn;
                RFight.ORON = oldRingOn;
                RFight.BWSON = brokenWoodenSwordOn;
                RFight.ShowDialog();
                this.Close();
            }
            if (radioButton5.Checked == true)
            {
                this.TopMost = false;
                RFight = new RealFight();
                MapLevel = 5;
                RFight.playerMpInt = PlayerMpInt;
                RFight.maxMp = MaxMp;
                RFight.DefencePower = defPower;
                RFight.SwordBoost = SwordOn;
                RFight.Name = Name;
                RFight.ExpNum = Exp;
                RFight.Gold = gold;
                RFight.StrStat = strPowerStat;
                RFight.DefStat = defPowerStat;
                RFight.MapLvl = MapLevel;
                RFight.NewMapLvl = NewMapLevel;
                RFight.YourLevel = playerLevel;
                RFight.oldBowBought = oldBow;
                RFight.oldHatBought = oldHat;
                RFight.oldShirtBought = oldShirt;
                RFight.oldPantsBought = oldPants;
                RFight.oldShoesBought = oldShoes;
                RFight.oldRingBought = oldRing;
                RFight.Character = selectedCharacter;
                //Equip
                RFight.OBON = oldBowOn;
                RFight.OHON = oldHatOn;
                RFight.OSON = oldShirtOn;
                RFight.OPON = oldPantsOn;
                RFight.OSEON = oldShoeOn;
                RFight.ORON = oldRingOn;
                RFight.BWSON = brokenWoodenSwordOn;
                RFight.ShowDialog();
                this.Close();
            }
            if (CaveradioButton26.Checked == true)
            {
                this.TopMost = false;
                Shop CShop = new Shop();
                CShop.StrStat = strPowerStat;
                CShop.DefStat = defPowerStat;
                CShop.playerMpInt = PlayerMpInt;
                CShop.maxMp = MaxMp;
                CShop.DefencePower = defPower;
                CShop.SwordBoost = SwordOn;
                CShop.Name = Name;
                CShop.ExpNum = Exp;
                CShop.Gold = gold;
                CShop.MapLvl = MapLevel;
                CShop.NewMapLvl = NewMapLevel;
                CShop.YourLevel = playerLevel;
                CShop.oldBowBought = oldBow;
                CShop.oldHatBought = oldHat;
                CShop.oldShirtBought = oldShirt;
                CShop.oldPantsBought = oldPants;
                CShop.oldShoesBought = oldShoes;
                CShop.oldRingBought = oldRing;
                CShop.Character = selectedCharacter;
                //Equip
                CShop.OBON = oldBowOn;
                CShop.OHON = oldHatOn;
                CShop.OSON = oldShirtOn;
                CShop.OPON = oldPantsOn;
                CShop.OSEON = oldShoeOn;
                CShop.ORON = oldRingOn;
                CShop.BWSON = brokenWoodenSwordOn;
                CShop.ShowDialog();
                this.Close();
            }
            if (MysteryRadioButton.Checked == true)
            {
                DialogResult confirmDialogResult = MessageBox.Show("This Looks Dangerous, Do you want to continue?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmDialogResult == DialogResult.Yes)

                {
                    this.TopMost = false;
                    RFight = new RealFight();
                MapLevel = 100;
                    RFight.StrStat = strPowerStat;
                    RFight.DefStat = defPowerStat;
                    RFight.playerMpInt = PlayerMpInt;
                    RFight.maxMp = MaxMp;
                    RFight.DefencePower = defPower;
                    RFight.SwordBoost = SwordOn;
                    RFight.Name = Name;
                    RFight.ExpNum = Exp;
                    RFight.Gold = gold;
                    RFight.MapLvl = MapLevel;
                    RFight.NewMapLvl = NewMapLevel;
                    RFight.YourLevel = playerLevel;
                    RFight.oldBowBought = oldBow;
                    RFight.oldHatBought = oldHat;
                    RFight.oldShirtBought = oldShirt;
                    RFight.oldPantsBought = oldPants;
                    RFight.oldShoesBought = oldShoes;
                    RFight.oldRingBought = oldRing;
                    RFight.Character = selectedCharacter;
                    //Equip
                    RFight.OBON = oldBowOn;
                    RFight.OHON = oldHatOn;
                    RFight.OSON = oldShirtOn;
                    RFight.OPON = oldPantsOn;
                    RFight.OSEON = oldShoeOn;
                    RFight.ORON = oldRingOn;
                    RFight.BWSON = brokenWoodenSwordOn;
                    RFight.ShowDialog();
                    this.Close();
                }

            }
        }


        private void ExpGold_Tick(object sender, EventArgs e)
        {
            Exp += ExpReward;
            Level.Text = playerLevel.ToString();
            Goldlabel.Text = gold.ToString();


        }

        private void CaveradioButton26_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CaveradioButton26.Checked == true)
            {
                button1.Text = "&Shop";
            }
            if (CaveradioButton26.Checked == false)
            {
                button1.Text = "&Battle!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            Equipment Equip = new Equipment();
            Equip.StrStat = strPowerStat;
            Equip.DefStat = defPowerStat;
            Equip.playerMpInt = PlayerMpInt;
            Equip.maxMp = MaxMp;
            Equip.DefencePower = defPower;
            Equip.SwordBoost = SwordOn;
            Equip.Name = Name;
            Equip.ExpNum = Exp;
            Equip.Gold = gold;
            Equip.MapLvl = MapLevel;
            Equip.YourLevel = playerLevel;
            Equip.NewMapLvl = NewMapLevel;
            Equip.Character = selectedCharacter;
            Equip.oldBowBought = oldBow;
            Equip.oldHatBought = oldHat;
            Equip.oldShirtBought = oldShirt;
            Equip.oldPantsBought = oldPants;
            Equip.oldShoesBought = oldShoes;
            Equip.oldRingBought = oldRing;
            //Equip
            Equip.OBON = oldBowOn;
            Equip.OHON = oldHatOn;
            Equip.OSON = oldShirtOn;
            Equip.OPON = oldPantsOn;
            Equip.OSEON = oldShoeOn;
            Equip.ORON = oldRingOn;
            Equip.BWSON = brokenWoodenSwordOn;
            this.Close();
            Equip.ShowDialog();


        }

        private void charTimer_Tick(object sender, EventArgs e)
        {
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
    }
}
