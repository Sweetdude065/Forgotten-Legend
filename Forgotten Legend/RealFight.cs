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

    public partial class RealFight : Form
    {
        private int MobPower;
        private int MobHeal;

        public int PlayerHpInt = 0;
        public int PlayerMpInt = 0;
        public int MonsterHpReturn = 50;
        public int MonsterMpReturn = 25;
        public int MonsterHpMax;

        public int MaxHp = 0;
        public int MaxMp = 0;
        public int Exp;
        public int gold;
        public int RewardGold;

        public int MobSpellCast;
        public int RewardExp;

        public Map1 Map;
        public Equipment Equip;

        public int MapLevel;
        public int NewMapLevel;
        public int MonsterName, MonsterNameRare;
        public int PlayerLevel;

        public int GearReward;
        public int LeatherHelmetReward = 1;
        public int PunchPower;
        public int HealPower;
        public int MagicPower;
        public int SwordPower;
        public int BowPower;
        public int HealPowerBonus;
        public int MagicPowerBonus;
        public int SwordPowerBonus;
        public int BowPowerBonus;
        public int PunchPowerBonus;
        public int SwordOn;
        public int selectedCharacter;
        public int armorBreak, critHit;

        public int oldBow;
        public int oldHat;
        public int oldShirt;
        public int oldPants;
        public int oldShoes;
        public int oldRing;

        public int oldRingOn, oldShoeOn, oldPantsOn, oldShirtOn, oldHatOn, oldBowOn, brokenWoodenSwordOn;
        public int slashPower, bowPower, defPower, evadePower, freezePower, firePower, bolasPower, strPowerStat, defPowerStat;

        public int i;
        public RealFight()
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

                PlayerLevel = value;

            }


        }
        public int SwordBoost
        {

            set

            {

                SwordOn = value;

            }


        }
        public int Character

        {

            set

            {

                selectedCharacter = value;

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
                MaxMp += value;
            }
        }
        public int NewMapLvl
        {
            set
            {
                NewMapLevel = value;
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
        private void Punchbutton_Click(object sender, EventArgs e)
        {
            Random rndDamage = new Random();
            PunchPower = rndDamage.Next(10, 16) + PunchPowerBonus + strPowerStat;
            MonsterHpReturn -= PunchPower;
            Punchbutton.Enabled = false;
            punchTimer.Start();
            richTextBox1.Text += Name + " hit the " + Monster.Text + ": " + PunchPower.ToString() + " Damage. \n";
            if (progressBar1.Value == 200)
            {
                progressBar1.Value = 0;

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MonsterHp.Text = MonsterHpReturn.ToString();
            MonsterMp.Text = MonsterMpReturn.ToString();
            PlayerHp.Text = PlayerHpInt.ToString();
            PlayerMp.Text = PlayerMpInt.ToString();
            PlayerName.Text = Name;
            if (PlayerHpInt > MaxHp)
            {
                PlayerHpInt = MaxHp;
            }
            if (PlayerMpInt > MaxMp)
            {
                PlayerMpInt = MaxMp;
            }
            if (PlayerHpInt > 0)
            {
                playerHPBar.Value = PlayerHpInt;
                if (playerHPBar.Value > MaxHp)
                {
                    playerHPBar.Value = MaxHp;
                }
            }
            if (0 > PlayerHpInt)
            {
                playerHPBar.Value = 0;
            }
            MonsterprogressBar.Maximum = MonsterHpMax;
            if ( MonsterHpReturn > 0)
            {
                MonsterprogressBar.Value = MonsterHpReturn;
                if (MonsterprogressBar.Value > MonsterHpMax)
                {
                    MonsterprogressBar.Value = MonsterHpMax;
                }
            }
            if (0 > MonsterHpReturn)
            {
                MonsterprogressBar.Value = 0;
            }
            if (MonsterHpReturn < 1)
            {
                richTextBox1.Text += "\nYou have won! \n";
                Punchbutton.Visible = false;
                healButton.Visible = false;
                slashButton.Visible = false;
                shootButton.Visible = false;
                defendButton.Visible = false;
                bolasButton.Visible = false;
                freezeButton.Visible = false;
                fireBallButton.Visible = false;
                winTimer.Start();
                mobAttackTimer.Stop();
                battleTimer.Stop();
            }
            if (PlayerHpInt < 1)
            {
                richTextBox1.Text += "\nYou have Lost! \n";
                Punchbutton.Visible = false;
                healButton.Visible = false;
                slashButton.Visible = false;
                shootButton.Visible = false;
                defendButton.Visible = false;
                bolasButton.Visible = false;
                freezeButton.Visible = false;
                fireBallButton.Visible = false;
                resetButton.Visible = true;
                mobAttackTimer.Stop();
                battleTimer.Stop();
            }
            if (PlayerMpInt < 5)
            {
                healButton.Enabled = false;
            }
            if (PlayerMpInt < 3)
            {
                slashButton.Enabled = false;
            }
            if (PlayerMpInt < 20)
            {
                freezeButton.Enabled = false;
            }
            if (PlayerMpInt < 1)
            {
                shootButton.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (MapLevel == 1)
            {
                Random rndMobDamage = new Random();
                MobPower = rndMobDamage.Next(10, 21) - defPower - defPowerStat;
                richTextBox1.Text += Monster.Text + " Hit you: " + MobPower.ToString() + " Damage. \n";
                Random rndMobSpellCasting = new Random();
                MobSpellCast = rndMobSpellCasting.Next(1, 4);
                if (MonsterHpReturn <= 65)
                {
                    if (MonsterMpReturn >= 10)
                    {
                        if (MobSpellCast == 3)
                        {
                            Random rndMobHeal = new Random();
                            MobHeal = rndMobHeal.Next(5, 16);
                            MonsterMpReturn -= 10;
                            richTextBox1.Text += Monster.Text + " Healed: " + MobHeal.ToString() + " Damage. \n";
                            MonsterHpReturn += MobHeal;
                        }
                    }
                }
            }
            if (MapLevel == 2)
            {
                Random rndMobDamage = new Random();
                MobPower = rndMobDamage.Next(17, 27) - defPower  - defPowerStat;
                richTextBox1.Text += Monster.Text + " Hit you: " + MobPower.ToString() + " Damage. \n";
                Random rndMobSpellCasting = new Random();
                MobSpellCast = rndMobSpellCasting.Next(1, 4);
                if (MonsterHpReturn <= 100)
                {
                    if (MonsterMpReturn >= 10)
                    {
                        if (MobSpellCast == 3)
                        {
                            Random rndMobHeal = new Random();
                            MobHeal = rndMobHeal.Next(10, 20);
                            MonsterMpReturn -= 10;
                            richTextBox1.Text += Monster.Text + " Healed: " + MobHeal.ToString() + " Damage. \n";
                            MonsterHpReturn += MobHeal;
                        }
                    }
                }
            }
            if (MapLevel == 3)
            {
                Random rndMobDamage = new Random();
                MobPower = rndMobDamage.Next(25, 36) - defPower - defPowerStat;
                richTextBox1.Text += Monster.Text + " Hit you: " + MobPower.ToString() + " Damage. \n";
                Random rndMobSpellCasting = new Random();
                MobSpellCast = rndMobSpellCasting.Next(1, 3);
                if (MonsterHpReturn <= 165)
                {
                    if (MonsterMpReturn >= 10)
                    {
                        if (MobSpellCast == 2)
                        {
                            Random rndMobHeal = new Random();
                            MobHeal = rndMobHeal.Next(15, 25);
                            MonsterMpReturn -= 10;
                            richTextBox1.Text += Monster.Text + " Healed: " + MobHeal.ToString() + " Damage. \n";
                            MonsterHpReturn += MobHeal;
                        }
                    }
                }
            }
            if (MapLevel == 4)
            {
                Random rndMobDamage = new Random();
                MobPower = rndMobDamage.Next(30, 42) - defPower - defPowerStat;
                richTextBox1.Text += Monster.Text + " Hit you: " + MobPower.ToString() + " Damage. \n";
                Random rndMobSpellCasting = new Random();
                MobSpellCast = rndMobSpellCasting.Next(1, 4);
                if (MonsterHpReturn <= 250)
                {
                    if (MonsterMpReturn >= 10)
                    {
                        if (MobSpellCast == 3)
                        {
                            Random rndMobHeal = new Random();
                            MobHeal = rndMobHeal.Next(35, 35);
                            MonsterMpReturn -= 10;
                            richTextBox1.Text += Monster.Text + " Healed: " + MobHeal.ToString() + " Damage. \n";
                            MonsterHpReturn += MobHeal;
                        }
                    }
                }
            }
            if (MapLevel == 5)
            {
                Random rndMobDamage = new Random();
                MobPower = rndMobDamage.Next(75, 100) - defPower - defPowerStat;
                richTextBox1.Text += Monster.Text + " Hit you: " + MobPower.ToString() + " Damage. \n";
                Random rndMobSpellCasting = new Random();
                MobSpellCast = rndMobSpellCasting.Next(1, 7);
                if (MonsterHpReturn <= 400)
                {
                    if (MonsterMpReturn >= 35)
                    {
                        if (MobSpellCast == 4)
                        {
                            richTextBox1.Text += "You Have been frozen for 5 seconds! \n";
                            MonsterMpReturn -= 35;
                            mobFreezeTimer.Start();
                        }
                    }
                    if (MonsterMpReturn >= 10)
                    {
                        if (MobSpellCast == 3)
                        {
                            Random rndMobHeal = new Random();
                            MobHeal = rndMobHeal.Next(10, 25);
                            MonsterMpReturn -= 10;
                            richTextBox1.Text += Monster.Text + " Healed: " + MobHeal.ToString() + " Damage. \n";
                            MonsterHpReturn += MobHeal;

                        }
                    }
                }
                if (MonsterHpReturn <= 100)
                {
                    if (MonsterMpReturn > 25)
                    {
                        if (MobSpellCast == 5)
                        {
                            Random rndMobHeal = new Random();
                            MobHeal = rndMobHeal.Next(100, 100);
                            MonsterMpReturn -= 25;
                            richTextBox1.Text += Monster.Text + " used Super Heal, it healed: " + MobHeal.ToString() + " Damage. \n";
                            MonsterHpReturn += MobHeal;

                        }
                    }
                }
            }
            if (MapLevel == 100)
            {
                Random rndMobDamage = new Random();
                MobPower = rndMobDamage.Next(100, 251) - defPower - defPowerStat;
                richTextBox1.Text += Monster.Text + " Hit you: " + MobPower.ToString() + " Damage. \n";
                Random rndMobSpellCasting = new Random();
                MobSpellCast = rndMobSpellCasting.Next(1, 7);
                if (MobSpellCast == 4)
                {
                    richTextBox1.Text += "You Have been frozen for 5 seconds! \n";
                    MonsterMpReturn -= 35;
                    mobFreezeTimer.Start();
                }
                if (MonsterHpReturn <= 2500)
                {
                    if (MonsterMpReturn > 0)
                    {
                        if (MobSpellCast == 3)
                        {
                            Random rndMobHeal = new Random();
                            MobHeal = rndMobHeal.Next(10, 20);
                            MonsterMpReturn -= 10;
                            richTextBox1.Text += Monster.Text + " Healed: " + MobHeal.ToString() + " Damage. \n";
                            MonsterHpReturn += MobHeal;

                        }
                    }
                }
                if (MonsterHpReturn <= 500)
                {
                    if (MonsterMpReturn > 0)
                    {
                        if (MobSpellCast == 5)
                        {
                            Random rndMobHeal = new Random();
                            MobHeal = rndMobHeal.Next(500, 750);
                            MonsterMpReturn -= 100;
                            richTextBox1.Text += Monster.Text + " Used Super Heal, It healed: " + MobHeal.ToString() + " Damage. \n";
                            MonsterHpReturn += MobHeal;

                        }
                    }
                }
            }
            charTimer.Start();
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
            PlayerHpInt -= MobPower;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            punchTimer.Stop();
            Punchbutton.Enabled = true;
            if(progressBar1.Value < 200)
            {
             progressBar1.Value += 50;
            }


        }

        private void bowTimer_Tick(object sender, EventArgs e)
        {
            bowTimer.Stop();
            shootButton.Enabled = true;
        }

        private void playerFreezeTimer_Tick(object sender, EventArgs e)
        {
            playerFreezeTimer.Stop();
            mobAttackTimer.Start();
            richTextBox1.Text += Monster.Text + " has been unfrozen! \n";

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

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            Punchbutton.Enabled = true;
        }

        private void skillCooldown_Tick(object sender, EventArgs e)
        {
            //tbc

        }

        private void freezeTimer_Tick(object sender, EventArgs e)
        {
            freezeTimer.Stop();
            freezeButton.Enabled = true;
        }

        private void fireBallButton_Click(object sender, EventArgs e)
        {

        }

        private void critHitTimer_Tick(object sender, EventArgs e)
        {
            critHitTimer.Stop();
            PunchPower /= 2;
        }

        private void shootButton_Click(object sender, EventArgs e)
        {
            shootButton.Enabled = false;
            PlayerMpInt -= 1;
            if (oldBowOn == 1)
            {
                bowPower += 2;
            }
            Random rndBowDamage = new Random();
            PunchPower = rndBowDamage.Next(4, 8) + BowPower + BowPowerBonus + strPowerStat;


            Random rndDamage = new Random();
            critHit = rndDamage.Next(1, 6);

            if (critHit == 2)
            {
                PunchPower *= 2;
                richTextBox1.Text += "Critical Hit! \n";
            }
            MonsterHpReturn -= PunchPower;

            bowTimer.Start();
            richTextBox1.Text += Name + " Shot the " + Monster.Text + ", It Hit: " + PunchPower.ToString() + " Damage. \n";
            critHitTimer.Start();
        }

        private void healButton_Click(object sender, EventArgs e)
        {
            Random rndHeal = new Random();
            HealPower = rndHeal.Next(15, 25) + HealPowerBonus;
            PlayerHpInt += HealPower;
            PlayerMpInt -= 5;
            if (oldShoeOn == 1)
            {
                PlayerMpInt += 1;
            }
            healButton.Enabled = false;
            healTimer.Start();
            richTextBox1.Text += Name + " Has healed: " + HealPower.ToString() + " Damage.\n";
        }

        private void healTimer_Tick(object sender, EventArgs e)
        {
            healTimer.Stop(); healButton.Enabled = true;
            if (PlayerHpInt > MaxHp)
            {
                healTimer.Start();
                healButton.Enabled = false;
            }
            if (PlayerHpInt < MaxHp)
            {
                healTimer.Stop();
                healButton.Enabled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (oldBowOn == 1)
            {
                strPowerStat -= 2;
            }
            if (oldShoeOn == 1)
            {
                strPowerStat -= 2;
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
                defPower -= 5;

            }
            Map1 aMapForm = new Map1();
            aMapForm.NewMapLvl = NewMapLevel;
            aMapForm.StrStat = strPowerStat;
            aMapForm.DefStat = defPowerStat;
            aMapForm.playerMpInt = PlayerMpInt;
            aMapForm.maxMp = MaxMp;
            aMapForm.DefencePower = defPower;
            aMapForm.Character = selectedCharacter;
            aMapForm.Name = Name;
            aMapForm.ExpNum = Exp;
            aMapForm.Gold = gold;
            aMapForm.NewMapLvl = NewMapLevel;
            aMapForm.SwordBoost = SwordOn;
            aMapForm.oldBowBought = oldBow;
            aMapForm.oldHatBought = oldHat;
            aMapForm.oldShirtBought = oldShirt;
            aMapForm.oldPantsBought = oldPants;
            aMapForm.oldShoesBought = oldShoes;
            aMapForm.oldRingBought = oldRing;
            //equiped stuff
            aMapForm.OBON = oldBowOn;
            aMapForm.OHON = oldHatOn;
            aMapForm.OSON = oldShirtOn;
            aMapForm.OPON = oldPantsOn;
            aMapForm.OSEON = oldShoeOn;
            aMapForm.ORON = oldRingOn;
            aMapForm.BWSON = brokenWoodenSwordOn;
            this.Hide();
            aMapForm.ShowDialog();
        }

        private void winTimer_Tick(object sender, EventArgs e)
        {
            winTimer.Stop();
            if (MapLevel == 1)
            {
                Random rndReward = new Random();
                RewardExp += rndReward.Next(1000, 1501);
                RewardGold += rndReward.Next(5, 10);
                gold += RewardGold;
                Exp += RewardExp;
                if (NewMapLevel == 0)
                {
                    NewMapLevel = 1;
                    //CutScene
                    RealCutScene aCut = new RealCutScene();
                    aCut.NewMapLvl = NewMapLevel;
                    aCut.Name = Name;
                    this.Hide();
                    aCut.ShowDialog();
                }
            }
            if (MapLevel == 2)
            {
                Random rndReward = new Random();
                RewardExp += rndReward.Next(1750, 2001);
                RewardGold += rndReward.Next(10, 17);
                gold += RewardGold;
                Exp += RewardExp;
                if (NewMapLevel == 1)
                {
                    NewMapLevel = 2;
                }
            }
            if (MapLevel == 3)
            {
                Random rndReward = new Random();
                RewardExp += rndReward.Next(2300, 2750);
                RewardGold += rndReward.Next(12, 18);
                gold += RewardGold;
                Exp += RewardExp;
                if (NewMapLevel == 2)
                {
                    NewMapLevel = 3;

                    //CutScene
                    RealCutScene aCut = new RealCutScene();
                    aCut.NewMapLvl = NewMapLevel;
                    aCut.Name = Name;
                    this.Hide();
                    aCut.ShowDialog();
                }

            }
            if (MapLevel == 4)
            {
                Random rndReward = new Random();
                RewardExp += rndReward.Next(3000, 3500);
                RewardGold += rndReward.Next(17, 19);
                gold += RewardGold;
                Exp += RewardExp;
                if (NewMapLevel == 3)
                {
                    NewMapLevel = 4;
                }
                if(MonsterNameRare == 7)
                {
                    RewardGold += 50;
                    gold += 50;
                }
                if (MonsterNameRare == 5)
                {
                    Exp += 3500;
                    RewardExp += 3500;
                }
            }
            if (MapLevel == 5)
            {
                Random rndReward = new Random();
                RewardExp += rndReward.Next(3000, 3500);
                RewardGold += rndReward.Next(25, 35);
                gold += RewardGold;
                Exp += RewardExp;
                if (NewMapLevel == 5)
                {
                    NewMapLevel = 5;

                    // CutScene
                    RealCutScene aCut = new RealCutScene();
                    aCut.NewMapLvl = NewMapLevel;
                    aCut.Name = Name;
                    this.Hide();
                    aCut.ShowDialog();
                }

            }
            MessageBox.Show("Exp Won: " + RewardExp.ToString() + "\nGold Won: " + RewardGold.ToString(), "Reward Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (oldBowOn == 1)
            {
                strPowerStat -= 2;
            }
            if (oldShoeOn == 1)
            {
                strPowerStat -= 2;
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
                defPower -= 5;

            }

            //Map
            Map1 aMapForm = new Map1();
            aMapForm.StrStat = strPowerStat;
            aMapForm.DefStat = defPowerStat;
            aMapForm.playerMpInt = PlayerMpInt;
            aMapForm.maxMp = MaxMp;
            aMapForm.DefencePower = defPower;
            aMapForm.Character = selectedCharacter;
            aMapForm.Name = Name;
            aMapForm.ExpNum = Exp;
            aMapForm.Gold = gold;
            aMapForm.NewMapLvl = NewMapLevel;
            aMapForm.SwordBoost = SwordOn;
            aMapForm.oldBowBought = oldBow;
            aMapForm.oldHatBought = oldHat;
            aMapForm.oldShirtBought = oldShirt;
            aMapForm.oldPantsBought = oldPants;
            aMapForm.oldShoesBought = oldShoes;
            aMapForm.oldRingBought = oldRing;
            //equiped stuff
            aMapForm.OBON = oldBowOn;
            aMapForm.OHON = oldHatOn;
            aMapForm.OSON = oldShirtOn;
            aMapForm.OPON = oldPantsOn;
            aMapForm.OSEON = oldShoeOn;
            aMapForm.ORON = oldRingOn;
            aMapForm.BWSON = brokenWoodenSwordOn;
            this.TopMost = false;
            this.Hide();
            this.Close();
            aMapForm.ShowDialog();



        }

        private void RealFight_Load_1(object sender, EventArgs e)
        {

            if (SwordOn == 1)
            {
                slashButton.Enabled = true;
                label9.Text = "(Mp Cost: 3)";
            }
            if (oldBowOn == 1)
            {
                shootButton.Enabled = true;
                label11.Text = "(Mp Cost: 1)";
                strPowerStat += 2;
            }
            if (oldShoeOn == 1)
            {
                strPowerStat += 2;
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
            if (oldRingOn == 1)
            {
                MaxMp += 25;
                PlayerMpInt += 25;
                MaxHp += 25;
                PlayerHpInt += 25;
                defPower += 5;
                freezeButton.Enabled = true;
                label12.Text = "(Mp Cost: 20)";

            }
            if (MapLevel == 1)
            {
                moblvllabel.Text = "2";
                Random rnd = new Random();
                MonsterName = rnd.Next(1, 5);

                if (MonsterName == 1)
                {
                    Monster.Text = "Medium Zombie";
                }
                if (MonsterName == 2)
                {
                    Monster.Text = "Medium Orc";
                }
                if (MonsterName == 3)
                {
                    Monster.Text = "Medium Cave Spider";
                }
                if (MonsterName == 4)
                {
                    Monster.Text = "Cute Baby Slime";
                }
                MonsterHpReturn = 65;
                MonsterHpMax = 65;
                MonsterMpReturn = 30;
            }
            if (MapLevel == 2)
            {
                moblvllabel.Text = "3";
                Random rnd = new Random();
                MonsterName = rnd.Next(1, 5);

                if (MonsterName == 1)
                {
                    Monster.Text = "Zombie Guard";
                }
                if (MonsterName == 2)
                {
                    Monster.Text = "Orc Guard";
                }
                if (MonsterName == 3)
                {
                    Monster.Text = "Large Cave Spider";
                }
                if (MonsterName == 4)
                {
                    Monster.Text = "Adolescent Slime";
                }
                MonsterHpReturn = 100;
                MonsterHpMax = 100;
                MonsterMpReturn = 50;
            }
            if (MapLevel == 3)
            {
                moblvllabel.Text = "4";
                Random rnd = new Random();
                MonsterName = rnd.Next(1, 5);

                if (MonsterName == 1)
                {
                    Monster.Text = "Zombie Mauler";
                }
                if (MonsterName == 2)
                {
                    Monster.Text = "Orc Knight";
                }
                if (MonsterName == 3)
                {
                    Monster.Text = "Evil Slime";
                }
                if (MonsterName == 4)
                {
                    Monster.Text = "Small Troll";
                }
                MonsterHpReturn = 165;
                MonsterMpReturn = 70;
                MonsterHpMax = 165;
            }
            if (MapLevel == 4)
            {
                moblvllabel.Text = "5";
                Random rnd = new Random();
                MonsterName = rnd.Next(1, 5);
                Random rndRare = new Random();
                MonsterNameRare = rndRare.Next(1, 10);
                if (MonsterNameRare == 7)
                {
                    Monster.Text += "Golden ";
                }
                if (MonsterNameRare == 5)
                {
                    Monster.Text += "Wise ";
                }
                if (MonsterName == 1)
                {
                    Monster.Text += "Sinister Evil Slime";
                    MonsterHpReturn = 275;
                    MonsterMpReturn = 90;
                    MonsterHpMax = 275;
                }
                if (MonsterName == 2)
                {
                    Monster.Text += "Wretched Green Slime";
                    MonsterHpReturn = 250;
                    MonsterMpReturn = 100;
                    MonsterHpMax = 250;
                }
                if (MonsterName == 3)
                {
                    Monster.Text += "Vile Blue Slime";
                    MonsterHpReturn = 230;
                    MonsterMpReturn = 110;
                    MonsterHpMax = 230;
                }
                if (MonsterName == 4)
                {
                    Monster.Text += "Jelly Troll";
                    MonsterHpReturn = 300;
                    MonsterMpReturn = 30;
                    MonsterHpMax = 300;
                }
            }
            if (MapLevel == 5)
            {
                moblvllabel.Text = "6";

                Monster.Text += "Slime King";
                MonsterHpReturn = 400;
                MonsterHpMax = 400;
                MonsterMpReturn = 100;

            }
            if (MapLevel == 100)
            {
                moblvllabel.Text = "30";
                Monster.Text = "???";
                MonsterHpReturn = 2500;
                MonsterMpReturn = 500;
                MonsterHpMax = 2500;
            }
            MonsterHp.Text += MonsterHpReturn.ToString();
            MonsterMp.Text += MonsterMpReturn.ToString();
            PlayerHp.Text += PlayerHpInt.ToString();
            PlayerMp.Text += PlayerMpInt.ToString();
            PlayerName.Text = Name;
            lvllabel.Text = PlayerLevel.ToString();
            if (PlayerLevel == 1)
            {
                PlayerHpInt += 100;
                MaxHp += 100;
                PlayerMpInt = 50;
                MaxMp = 50;
                PunchPowerBonus += 1;
                MagicPowerBonus += 1;
                BowPowerBonus += 1;
                HealPowerBonus += 1;
                SwordPowerBonus += 1;

            }
            if (PlayerLevel == 2)
            {
                PlayerHpInt += 110;
                MaxHp += 110;
                PlayerMpInt = 55;
                MaxMp = 55;
                PunchPowerBonus += 2;
                MagicPowerBonus += 2;
                BowPowerBonus += 2;
                HealPowerBonus += 2;
                SwordPowerBonus += 2;

            }
            if (PlayerLevel == 3)
            {
                PlayerHpInt += 120;
                MaxHp += 120;
                PlayerMpInt = 60;
                MaxMp = 60;
                PunchPowerBonus += 4;
                MagicPowerBonus += 4;
                BowPowerBonus += 4;
                HealPowerBonus += 4;
                SwordPowerBonus += 4;
            }
            if (PlayerLevel == 4)
            {
                PlayerHpInt += 130;
                MaxHp += 130;
                PlayerMpInt = 65;
                MaxMp = 65;
                PunchPowerBonus += 6;
                MagicPowerBonus += 6;
                BowPowerBonus += 6;
                HealPowerBonus += 6;
                SwordPowerBonus += 6;
            }
            if (PlayerLevel == 5)
            {
                PlayerHpInt += 140;
                MaxHp += 140;
                PlayerMpInt = 70;
                MaxMp = 70;
                PunchPowerBonus += 8;
                MagicPowerBonus += 8;
                BowPowerBonus += 8;
                HealPowerBonus += 8;
                SwordPowerBonus += 8;
            }
            if (PlayerLevel == 6)
            {
                PlayerHpInt += 150;
                MaxHp += 150;
                PlayerMpInt = 75;
                MaxMp = 75;
                PunchPowerBonus += 10;
                MagicPowerBonus += 10;
                BowPowerBonus += 10;
                HealPowerBonus += 10;
                SwordPowerBonus += 10;
            }
            if (PlayerLevel == 7)
            {
                PlayerHpInt += 160;
                MaxHp += 160;
                PlayerMpInt = 80;
                MaxMp = 80;
                PunchPowerBonus += 12;
                MagicPowerBonus += 12;
                BowPowerBonus += 12;
                HealPowerBonus += 12;
                SwordPowerBonus += 12;
            }
            if (PlayerLevel == 8)
            {
                PlayerHpInt += 170;
                MaxHp += 170;
                PlayerMpInt = 85;
                MaxMp = 85;
                PunchPowerBonus += 14;
                MagicPowerBonus += 14;
                BowPowerBonus += 14;
                HealPowerBonus += 14;
                SwordPowerBonus += 14;
            }
            if (PlayerLevel == 9)
            {
                PlayerHpInt += 180;
                MaxHp += 180;
                PlayerMpInt = 90;
                MaxMp = 90;
                PunchPowerBonus += 16;
                MagicPowerBonus += 16;
                BowPowerBonus += 16;
                HealPowerBonus += 16;
                SwordPowerBonus += 16;
            }
            if (PlayerLevel == 10)
            {
                PlayerHpInt += 200;
                MaxHp += 200;
                PlayerMpInt = 100;
                MaxMp = 100;
                PunchPowerBonus += 20;
                MagicPowerBonus += 20;
                BowPowerBonus += 20;
                HealPowerBonus += 20;
                SwordPowerBonus += 20;
            }
            if (PlayerLevel == 11)
            {
                PlayerHpInt += 220;
                MaxHp += 220;
                PlayerMpInt = 110;
                MaxMp = 110;
                PunchPowerBonus += 24;
                MagicPowerBonus += 24;
                BowPowerBonus += 24;
                HealPowerBonus += 24;
                SwordPowerBonus += 24;
            }
            if (PlayerLevel == 12)
            {
                PlayerHpInt += 240;
                MaxHp += 240;
                PlayerMpInt = 120;
                MaxMp = 120;
                PunchPowerBonus += 28;
                MagicPowerBonus += 28;
                BowPowerBonus += 28;
                HealPowerBonus += 28;
                SwordPowerBonus += 28;
            }
            playerHPBar.Maximum = PlayerHpInt;
            playerHPBar.Value = PlayerHpInt;
        }
        private void firstTimer_Tick(object sender, EventArgs e)
        {
          
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

        private void slashButton_Click(object sender, EventArgs e)
        {
            slashButton.Enabled = false;
            PlayerMpInt -= 3;
            Random rndDamage = new Random();
            PunchPower = rndDamage.Next(5, 8) + SwordPowerBonus + strPowerStat;
            armorBreak = rndDamage.Next(1, 6);

            if (armorBreak == 3)
            {
                PunchPower += 3;
                richTextBox1.Text += Name + " Broke the " + Monster.Text + " Armor by: 3! \n";
            }
            MonsterHpReturn -= PunchPower;

            slashTimer.Start();
            richTextBox1.Text += Name + " Slashed the " + Monster.Text + ", It Hit: " + PunchPower.ToString() + " Damage. \n";
        }

        private void slashTimer_Tick(object sender, EventArgs e)
        {
            slashTimer.Stop();
            slashButton.Enabled = true;
        }

        private void mobFreezeTimer_Tick(object sender, EventArgs e)
        {
            mobFreezeTimer.Stop();
            mobUnfreezeTimer.Start();
            Punchbutton.Visible = false;
            healButton.Visible = false;
            slashButton.Visible = false;
            shootButton.Visible = false;
            defendButton.Visible = false;
            bolasButton.Visible = false;
            freezeButton.Visible = false;
            fireBallButton.Visible = false;
        }

        private void mobUnfreezeTimer_Tick(object sender, EventArgs e)
        {
            mobUnfreezeTimer.Stop();
            Punchbutton.Visible = true;
            healButton.Visible = true;
            slashButton.Visible = true;
            shootButton.Visible = true;
            defendButton.Visible = true;
            bolasButton.Visible = true;
            freezeButton.Visible = true;
            fireBallButton.Visible = true;

        }

        private void freezeButton_Click(object sender, EventArgs e)
        {
            mobAttackTimer.Stop();
            freezeButton.Enabled = false;
            PlayerMpInt -= 20;
            richTextBox1.Text += Monster.Text + " is frozen for 3 Seconds!\n";
            playerFreezeTimer.Start();
            freezeTimer.Start();
            if (MonsterHpReturn < 1)
            {
                freezeTimer.Stop();
            }
        }
    }
}
