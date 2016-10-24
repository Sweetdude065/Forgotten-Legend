using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forgotten_Legend
{
    partial class AboutBox1 : Form
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

        public AboutBox1()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = "";
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
        //equiped gears
        public int BWSON
        {
            set
            {
                brokenWoodenSwordOn = value;
            }
        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

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
        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void AboutBox1_Load(object sender, EventArgs e)
        {
            if (selectedCharacter == 1)
            {
                logoPictureBox.BackgroundImage = Forgotten_Legend.Properties.Resources.MaleAdvent;
            }
            if (selectedCharacter == 2)
            {
                logoPictureBox.BackgroundImage = Forgotten_Legend.Properties.Resources.ElfMaleAdvent;
            }
            if (selectedCharacter == 3)
            {
                logoPictureBox.BackgroundImage = Forgotten_Legend.Properties.Resources.FemaleAdvent;
            }
            if (selectedCharacter == 4)
            {
                logoPictureBox.BackgroundImage = Forgotten_Legend.Properties.Resources.mage;
            }
            if (selectedCharacter == 0)
            {
                logoPictureBox.BackgroundImage = Forgotten_Legend.Properties.Resources.MaleAdvent;
            }
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
