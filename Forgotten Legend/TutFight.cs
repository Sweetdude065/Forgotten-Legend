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

    public partial class TutFight : Form
    {
        public int PlayerHpInt = 100;
        public int PlayerMpInt = 50;
       public int MonsterHpReturn = 50;
       public int MonsterMpReturn = 25;
        public int Exp;
        public int gold, selectedCharacter = 1;



        public TutFight()
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
        private void Fight1_Load(object sender, EventArgs e)
        {

            pictureBox1.Image = Forgotten_Legend.Properties.Resources.MaleAdvent;

            Random rnd = new Random();
            int Monster = rnd.Next(1, 4);


            if (Monster == 1)
            {
                this.Monster.Text = "Small Zombie";
            }
            if (Monster == 2)
            {
                this.Monster.Text = "Small Orc";
            }
            if (Monster == 3)
            {
                this.Monster.Text = "Small Cave Spider";
            }
            MonsterHp.Text += MonsterHpReturn.ToString();
            MonsterMp.Text += MonsterMpReturn.ToString();
            PlayerHp.Text += PlayerHpInt.ToString();
            PlayerMp.Text += PlayerMpInt.ToString();
            PlayerName.Text = Name;
            

        }

        private void Punchbutton_Click(object sender, EventArgs e)
        {
            Random rndDamage = new Random();
            int PunchPower = rndDamage.Next(10, 16);
            MonsterHpReturn -= PunchPower;
            Punchbutton.Enabled = false;
            punchTimer.Start();
            richTextBox1.Text += Name + " Hit " + Monster.Text + ": " + PunchPower.ToString() + " Damage. \n";


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MonsterHp.Text = MonsterHpReturn.ToString();
            MonsterMp.Text = MonsterMpReturn.ToString();
            PlayerHp.Text = PlayerHpInt.ToString();
            PlayerMp.Text = PlayerMpInt.ToString();
            if (PlayerHpInt > 100)
            {
                PlayerHpInt = 100;
            }
            if (MonsterHpReturn <= 0)
            {
                richTextBox1.Text += "\nYou have won!";
                Punchbutton.Visible = false;
                healButton.Visible = false;
                winTimer.Start();
                mobAttackTimer.Stop();
                battleTimer.Stop();
            }
            if (PlayerHpInt <= 0)
            {
                richTextBox1.Text += "\nYou have Lost!";
                Punchbutton.Visible = false;
                healButton.Visible = false;
                resetButton.Visible = true;
                mobAttackTimer.Stop();
                battleTimer.Stop();
            }
            if (PlayerMpInt < 5)
            {
                healButton.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random rndMobDamage = new Random();
            int MobPower = rndMobDamage.Next(7, 12);
            PlayerHpInt -= MobPower;
            richTextBox1.Text += Monster.Text +" Hit you: " + MobPower.ToString() + " Damage. \n";
            firstTimer.Start();
            if (selectedCharacter == 1)
            {
                pictureBox1.BackgroundImage = Forgotten_Legend.Properties.Resources.MaleAdventGotHit;
            }
            if (selectedCharacter == 2)
            {
                pictureBox1.BackgroundImage = Forgotten_Legend.Properties.Resources.ElfMaleAdventGotHit;
            }
            if (selectedCharacter == 3)
            {
                pictureBox1.BackgroundImage = Forgotten_Legend.Properties.Resources.FemaleAdventGotHit;
            }
            if (selectedCharacter == 4)
            {
                pictureBox1.BackgroundImage = Forgotten_Legend.Properties.Resources.mageGotHit;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            punchTimer.Stop(); Punchbutton.Enabled = true;
        }

        private void healButton_Click(object sender, EventArgs e)
        {
            Random rndHeal = new Random();
            int HealPower = rndHeal.Next(15, 25);
            PlayerHpInt += HealPower;
            PlayerMpInt -= 5;
            healButton.Enabled = false;
            healTimer.Start();
            richTextBox1.Text += Name + " Has healed: " + HealPower.ToString() + " Damage.\n";
        }

        private void healTimer_Tick(object sender, EventArgs e)
        {
            healTimer.Stop(); healButton.Enabled = true;
            if(PlayerHpInt > 100)
            {
                healTimer.Start();
                healButton.Enabled = false;
            }
            if(PlayerHpInt < 100)
            {
                healTimer.Stop();
                healButton.Enabled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
        PlayerHpInt = 100;
        PlayerMpInt = 50;
        MonsterHpReturn = 50;
        MonsterMpReturn = 25;
            mobAttackTimer.Start();
            battleTimer.Start();
            richTextBox1.Clear();
            Punchbutton.Visible = true;
            healButton.Visible = true;

        }

        private void firstTimer_Tick(object sender, EventArgs e)
        {
            firstTimer.Stop();
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // bind this method to its TextChanged event handler:
            // richTextBox.TextChanged += richTextBox_TextChanged;
            // set the current caret position to the end
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }

        private void winTimer_Tick(object sender, EventArgs e)
        {
            winTimer.Stop();
            Random rndReward = new Random();
            int RewardExp = rndReward.Next(750, 1000);
            int RewardGold = rndReward.Next(5, 8);
            gold += RewardGold;
            Exp += RewardExp;
            MessageBox.Show("Exp Won: " + Exp.ToString() + "\nGold Won: " + gold.ToString(), "Reward Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information );
            MessageBox.Show("You Found a Broken Wooden Sword!", "Reward Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Map1 aMapForm = new Map1();
            aMapForm.Character = selectedCharacter;
            aMapForm.Name = Name;
            aMapForm.ExpNum = Exp;
            aMapForm.Gold = gold;

            aMapForm.ShowDialog();
            this.Close();

        }
    }
}
