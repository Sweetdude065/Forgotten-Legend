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
    public partial class StatusForm : Form
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
        public int slashPower, bowPower, defPowerStat, strPowerStat, defPower, evadePower, freezePower, firePower, bolasPower, PlayerHpInt, PlayerMpInt, strPower;

        public int MaxHp = 0, MaxHpBonus =  0;
        public int MaxMp = 0, MaxMpBonus = 0;
        public StatusForm()
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (oldRingOn == 1)
            {
                MaxMpBonus -= 25;
                MaxHpBonus -= 25;
            }
            if (oldBowOn == 1)
            {
                strPower -= 2;
            }
            if (oldShoeOn == 1)
            {
                strPower -= 2;
                defPower -= 3;
            }
            if (oldPantsOn == 1)
            {
                defPower -= 4;
            }
            if (oldShirtOn == 1)
            {
                defPower -= 5;
            }
            if (oldHatOn == 1)
            {
                defPower -= 3;
            }
            if (oldRingOn == 1)
            {
                MaxMpBonus -= 25;
                MaxHpBonus -= 25;
                defPower -= 5;
            }
            this.Close();
            Map1 Map = new Map1();
            Map.playerMpInt = PlayerMpInt;
            Map.maxMp = MaxMp;
            Map.StrStat = strPowerStat;
            Map.DefStat = defPowerStat;
            Map.DefencePower = defPower;
            Map.SwordBoost = SwordOn;
            Map.Name = Name;
            Map.ExpNum = Exp;
            Map.Gold = gold;
            Map.MapLvl = MapLevel;
            Map.NewMapLvl = NewMapLevel;
            Map.YourLevel = playerLevel;
            Map.oldBowBought = oldBow;
            Map.oldHatBought = oldHat;
            Map.oldShirtBought = oldShirt;
            Map.oldPantsBought = oldPants;
            Map.oldShoesBought = oldShoes;
            Map.oldRingBought = oldRing;
            Map.Character = selectedCharacter;
            //Equip
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

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            name.Text = Name;
            level.Text = playerLevel.ToString();
            ExpLabel.Text = Exp.ToString();
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

            goldLabel.Text = gold.ToString();
            strLabel.Text = strPowerStat.ToString();
            totalDefLabel.Text = "Total = "  + (defPower + defPowerStat);
            totalStrLabel.Text = "Total = "  + (strPowerStat + strPower);
            totalHP.Text = "Total = " + (MaxHp + MaxHpBonus);
            totalMP.Text = "Total = " + (MaxMp + MaxMpBonus);


            deflabel.Text = defPowerStat.ToString();
            if(oldRingOn == 1)
            {
                skillLabel.Text = "Freeze Level 1";
            }
            if (defPlus.Checked == true)
            {
                defPlus.Checked = false;
                defPowerStat += 1;
                Statpoints -= 1;
            }
            if (strPlus.Checked == true)
            {
                strPlus.Checked = false;
                strPowerStat += 1;
                Statpoints -= 1;
            }
            if (Statpoints == 0)
            {
                defPlus.Enabled = false;
                swordPlus.Enabled = false;
                strPlus.Enabled = false;
                bowPlus.Enabled = false;
                defendPlus.Enabled = false;
            }
            if (Statpoints > 0)
            {
                defPlus.Enabled = true;
                swordPlus.Enabled = true;
                strPlus.Enabled = true;
                bowPlus.Enabled = true;
                defendPlus.Enabled = true;
            }
            defGearLabel.Text = "(Gear Bonus: " + defPower + ")";
            StrGearLabel.Text = "(Gear Bonus: " + strPower + ")";
            HpLabel.Text = MaxHp.ToString();
            MpLabel.Text = MaxMp.ToString();
            MpGearBonus.Text = "(Gear Bonus: " + MaxMpBonus + ")";
            HpGearBonus.Text = "(Gear Bonus: " + MaxHpBonus + ")";
            statLabel.Text = Statpoints.ToString();
        }

        private void defPlus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pointInTimer_Tick(object sender, EventArgs e)
        {
            pointInTimer.Stop();
            if (playerLevel == 1)
            {
                Statpoints = 1;
            }
            if (playerLevel == 2)
            {
                Statpoints = 2;
            }
            if (playerLevel == 3)
            {
                Statpoints = 3;
            }
            if (playerLevel == 3)
            {
                Statpoints = 3;
            }
            if (playerLevel == 4)
            {
                Statpoints = 4;
            }
            if (playerLevel == 5)
            {
                Statpoints = 5;
            }
            if (playerLevel == 6)
            {
                Statpoints = 6;
            }
            if (playerLevel == 7)
            {
                Statpoints = 7;
            }
            if (playerLevel == 8)
            {
                Statpoints = 8;
            }
            if (playerLevel == 9)
            {
                Statpoints = 9;
            }
            if (playerLevel == 10)
            {
                Statpoints = 11;
            }
            if (playerLevel == 12)
            {
                Statpoints = 13;
            }
            if (playerLevel == 1)
            {
                PlayerHpInt += 100;
                MaxHp += 100;
                PlayerMpInt = 50;
                MaxMp = 50;
            }
            if (playerLevel == 2)
            {
                PlayerHpInt += 110;
                MaxHp += 110;
                PlayerMpInt = 55;
                MaxMp = 55;
            }
            if (playerLevel == 3)
            {
                PlayerHpInt += 120;
                MaxHp += 120;
                PlayerMpInt = 60;
                MaxMp = 60;
            }
            if (playerLevel == 4)
            {
                PlayerHpInt += 130;
                MaxHp += 130;
                PlayerMpInt = 65;
                MaxMp = 65;
            }
            if (playerLevel == 5)
            {
                PlayerHpInt += 140;
                MaxHp += 140;
                PlayerMpInt = 70;
                MaxMp = 70;
            }
            if (playerLevel == 6)
            {
                PlayerHpInt += 150;
                MaxHp += 150;
                PlayerMpInt = 75;
                MaxMp = 75;
            }
            if (playerLevel == 7)
            {
                PlayerHpInt += 160;
                MaxHp += 160;
                PlayerMpInt = 80;
                MaxMp = 80;
            }
            if (playerLevel == 8)
            {
                PlayerHpInt += 170;
                MaxHp += 170;
                PlayerMpInt = 85;
                MaxMp = 85;
            }
            if (playerLevel == 9)
            {
                PlayerHpInt += 180;
                MaxHp += 180;
                PlayerMpInt = 90;
                MaxMp = 90;
            }
            if (playerLevel == 10)
            {
                PlayerHpInt += 200;
                MaxHp += 200;
                PlayerMpInt = 100;
                MaxMp = 100;
            }
            if (playerLevel == 11)
            {
                PlayerHpInt += 220;
                MaxHp += 220;
                PlayerMpInt = 110;
                MaxMp = 110;
            }
            if (playerLevel == 12)
            {
                PlayerHpInt += 240;
                MaxHp += 240;
                PlayerMpInt = 120;
                MaxMp = 120;
            }


            if (oldRingOn == 1)
            {
                MaxMpBonus += 25;
                MaxHpBonus += 25;
                defPower += 5;
            }
            if (oldBowOn == 1)
            {
                strPower += 2;
            }
            if (oldShoeOn == 1)
            {
                strPower += 2;
                defPower += 3;
            }
            if (oldPantsOn == 1)
            {
                defPower += 4;
            }
            if (oldShirtOn == 1)
            {
                defPower += 5;
            }
            if (oldHatOn == 1)
            {
                defPower += 3;
            }


                Statpoints -= defPowerStat;
            Statpoints -= strPowerStat;

        }

        private void timer1_Tick(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (playerLevel == 1)
            {
                Statpoints = 1;
            }
            if (playerLevel == 2)
            {
                Statpoints = 2;
            }
            if (playerLevel == 3)
            {
                Statpoints = 3;
            }
            if (playerLevel == 3)
            {
                Statpoints = 3;
            }
            if (playerLevel == 4)
            {
                Statpoints = 4;
            }
            if (playerLevel == 5)
            {
                Statpoints = 5;
            }
            if (playerLevel == 6)
            {
                Statpoints = 6;
            }
            if (playerLevel == 7)
            {
                Statpoints = 7;
            }
            if (playerLevel == 8)
            {
                Statpoints = 8;
            }
            if (playerLevel == 9)
            {
                Statpoints = 9;
            }
            if (playerLevel == 10)
            {
                Statpoints = 11;
            }
            if (playerLevel == 12)
            {
                Statpoints = 13;
            }
            defPowerStat = 0;
            strPowerStat = 0;
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
        private void StatusForm_Load(object sender, EventArgs e)
        {
            Statpoints = 0;
            this.TopMost = true;
        }
    }
}
