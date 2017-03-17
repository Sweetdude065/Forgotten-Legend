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
    public partial class Equipment : Form
    {
        //ints and decimals
        #region
        public Map1 Map;
        public RealFight RFight;
        public int LeatherHelmetReward, SwordOn, BowOn, gold, Exp, 
            NewMapLevel, playerLevel, MapLevel, selectedCharacter, oldBow, 
            oldHat, oldShirt, oldPants, oldShoes, oldRing,
            oldRingOn, oldShoeOn, oldPantsOn, oldShirtOn, oldHatOn, oldBowOn, 
            brokenWoodenSwordOn, ironsword, slashPower, bowPower, defPower, 
            evadePower, freezePower, firePower, bolasPower, PlayerHpInt, 
            PlayerMpInt, strPowerStat, defPowerStat, MaxHp, MaxMp;
        #endregion

        public Equipment()
        {
            InitializeComponent();
        }
        //pulling ints from form to form
        #region
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

        public int playerMpInt
        {
            set
            {
                PlayerMpInt = value;
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
        public int maxMp
        {
            set
            {
                MaxMp = value;
            }
        }
        public int MapLvl
        {
            set
            {
                MapLevel = value;
            }
        }

        public int DefencePower
        {
            set
            {
                defPower = value;
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
        #endregion

        //when the form loads
        #region
        private void Equipment_Load(object sender, EventArgs e)
        {
            defPower = 0;

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
            //equip
            if (oldBow == 1)
            {
                mainComboBox.Items.Add("Old Bow");
            }
            if (oldHat == 1)
            {
                headComboBox.Items.Add("Old Hat");
            }
            if (oldShirt == 1)
            {
                bodyComboBox.Items.Add("Old Shirt");
            }
            if (oldPants == 1)
            {
                legsComboBox.Items.Add("Old Pants");
            }
            if (oldShoes == 1)
            {
                shoeComboBox.Items.Add("Old Shoes");
            }
            if (oldRing == 1)
            {
                ringComboBox.Items.Add("Old Ring");
            }

            if (oldBowOn == 1)
            {
                mainComboBox.Text = "Old Bow";
            }
            if (oldHatOn == 1)
            {
                headComboBox.Text = "Old Hat";
            }
            if (oldShirtOn == 1)
            {
                bodyComboBox.Text = "Old Shirt";
            }
            if (oldPantsOn == 1)
            {
                legsComboBox.Text = "Old Pants";
            }
            if (oldShoeOn == 1)
            {
                shoeComboBox.Text = "Old Shoes";
            }
            if (oldRingOn == 1)
            {
                ringComboBox.Text = "Old Ring";
            }
            if (brokenWoodenSwordOn == 1)
            {
                mainComboBox.Text = "Broken Wooden Sword";
            }
            this.TopMost = true;
        }
        #endregion

        //gear saelfcotion
        #region
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainComboBox.Text == "Broken Wooden Sword")
            {
                SwordOn = 1;
                brokenWoodenSwordOn = 1;
                oldBowOn = 0;
                BowOn = 0;
            }
            if (mainComboBox.Text == "Old Bow")
            {
                BowOn = 1;
                oldBowOn = 1;
                SwordOn = 0;
                brokenWoodenSwordOn = 0;
            }
            if(mainComboBox.Text == "(None)")
            {
                oldBowOn = 0;
                SwordOn = 0;
                oldBowOn = 0;
                brokenWoodenSwordOn = 0;
            }
        }
        private void ringComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ringComboBox.Text == "Old Ring")
            {
                defPower += 5;
                oldRingOn = 1;
            }
        }
        private void bodyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bodyComboBox.Text == "Old Shirt")
            {
                oldShirtOn = 1;
            }
        }

        private void legsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (legsComboBox.Text == "Old Pants")
            {
                oldPantsOn = 1;
            }
        }

        private void shoeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shoeComboBox.Text == "Old Shoes")
            {
                oldShoeOn = 1;
            }
        }
        private void HeadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (headComboBox.Text == "Old Hat")
            {
                oldHatOn = 1;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Map1 Map = new Map1();
            Map.StrStat = strPowerStat;
            Map.DefStat = defPowerStat;
            Map.playerMpInt = PlayerMpInt;
            Map.maxMp = MaxMp;
            Map.DefencePower = defPower;
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
            Map.ShowDialog();
        }
    }
}
