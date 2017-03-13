namespace Forgotten_Legend
{
    partial class TutFight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutFight));
            this.Monster = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.PlayerHp = new System.Windows.Forms.Label();
            this.PlayerMp = new System.Windows.Forms.Label();
            this.Punchbutton = new System.Windows.Forms.Button();
            this.MonsterMp = new System.Windows.Forms.Label();
            this.MonsterHp = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.punchTimer = new System.Windows.Forms.Timer(this.components);
            this.battleTimer = new System.Windows.Forms.Timer(this.components);
            this.mobAttackTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.healButton = new System.Windows.Forms.Button();
            this.winTimer = new System.Windows.Forms.Timer(this.components);
            this.healTimer = new System.Windows.Forms.Timer(this.components);
            this.MoblevelLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.firstTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Monster
            // 
            this.Monster.AutoSize = true;
            this.Monster.BackColor = System.Drawing.Color.Transparent;
            this.Monster.ForeColor = System.Drawing.Color.White;
            this.Monster.Location = new System.Drawing.Point(171, 29);
            this.Monster.Name = "Monster";
            this.Monster.Size = new System.Drawing.Size(0, 13);
            this.Monster.TabIndex = 1;
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.BackColor = System.Drawing.Color.Transparent;
            this.PlayerName.ForeColor = System.Drawing.Color.White;
            this.PlayerName.Location = new System.Drawing.Point(171, 133);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(0, 13);
            this.PlayerName.TabIndex = 3;
            // 
            // PlayerHp
            // 
            this.PlayerHp.AutoSize = true;
            this.PlayerHp.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHp.ForeColor = System.Drawing.Color.White;
            this.PlayerHp.Location = new System.Drawing.Point(202, 157);
            this.PlayerHp.Name = "PlayerHp";
            this.PlayerHp.Size = new System.Drawing.Size(25, 13);
            this.PlayerHp.TabIndex = 4;
            this.PlayerHp.Text = "HP:";
            // 
            // PlayerMp
            // 
            this.PlayerMp.AutoSize = true;
            this.PlayerMp.BackColor = System.Drawing.Color.Transparent;
            this.PlayerMp.ForeColor = System.Drawing.Color.White;
            this.PlayerMp.Location = new System.Drawing.Point(202, 187);
            this.PlayerMp.Name = "PlayerMp";
            this.PlayerMp.Size = new System.Drawing.Size(26, 13);
            this.PlayerMp.TabIndex = 5;
            this.PlayerMp.Text = "MP:";
            // 
            // Punchbutton
            // 
            this.Punchbutton.Location = new System.Drawing.Point(13, 12);
            this.Punchbutton.Name = "Punchbutton";
            this.Punchbutton.Size = new System.Drawing.Size(65, 23);
            this.Punchbutton.TabIndex = 6;
            this.Punchbutton.Text = "&Punch";
            this.Punchbutton.UseVisualStyleBackColor = true;
            this.Punchbutton.Click += new System.EventHandler(this.Punchbutton_Click);
            // 
            // MonsterMp
            // 
            this.MonsterMp.AutoSize = true;
            this.MonsterMp.BackColor = System.Drawing.Color.Transparent;
            this.MonsterMp.ForeColor = System.Drawing.Color.White;
            this.MonsterMp.Location = new System.Drawing.Point(201, 82);
            this.MonsterMp.Name = "MonsterMp";
            this.MonsterMp.Size = new System.Drawing.Size(26, 13);
            this.MonsterMp.TabIndex = 10;
            this.MonsterMp.Text = "MP:";
            // 
            // MonsterHp
            // 
            this.MonsterHp.AutoSize = true;
            this.MonsterHp.BackColor = System.Drawing.Color.Transparent;
            this.MonsterHp.ForeColor = System.Drawing.Color.White;
            this.MonsterHp.Location = new System.Drawing.Point(201, 51);
            this.MonsterHp.Name = "MonsterHp";
            this.MonsterHp.Size = new System.Drawing.Size(25, 13);
            this.MonsterHp.TabIndex = 9;
            this.MonsterHp.Text = "HP:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 213);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(277, 147);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(299, 390);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 163;
            this.lineShape2.X2 = 163;
            this.lineShape2.Y1 = -11;
            this.lineShape2.Y2 = 271;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 163;
            this.lineShape1.X2 = 307;
            this.lineShape1.Y1 = 107;
            this.lineShape1.Y2 = 107;
            // 
            // punchTimer
            // 
            this.punchTimer.Interval = 1250;
            this.punchTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // battleTimer
            // 
            this.battleTimer.Enabled = true;
            this.battleTimer.Interval = 10;
            this.battleTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mobAttackTimer
            // 
            this.mobAttackTimer.Enabled = true;
            this.mobAttackTimer.Interval = 3000;
            this.mobAttackTimer.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "MP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(170, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "HP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(171, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "MP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(171, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "HP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "(MP Cost: 0)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(84, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "(MP Cost: 5)";
            // 
            // healButton
            // 
            this.healButton.Location = new System.Drawing.Point(84, 12);
            this.healButton.Name = "healButton";
            this.healButton.Size = new System.Drawing.Size(65, 23);
            this.healButton.TabIndex = 18;
            this.healButton.Text = "&Heal";
            this.healButton.UseVisualStyleBackColor = true;
            this.healButton.Click += new System.EventHandler(this.healButton_Click);
            // 
            // winTimer
            // 
            this.winTimer.Interval = 1000;
            this.winTimer.Tick += new System.EventHandler(this.winTimer_Tick);
            // 
            // healTimer
            // 
            this.healTimer.Interval = 7500;
            this.healTimer.Tick += new System.EventHandler(this.healTimer_Tick);
            // 
            // MoblevelLabel
            // 
            this.MoblevelLabel.AutoSize = true;
            this.MoblevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.MoblevelLabel.ForeColor = System.Drawing.Color.White;
            this.MoblevelLabel.Location = new System.Drawing.Point(171, 9);
            this.MoblevelLabel.Name = "MoblevelLabel";
            this.MoblevelLabel.Size = new System.Drawing.Size(45, 13);
            this.MoblevelLabel.TabIndex = 20;
            this.MoblevelLabel.Text = "Level: 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(170, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Level: 1";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 364);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(116, 23);
            this.resetButton.TabIndex = 24;
            this.resetButton.Text = "&Retry?";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // firstTimer
            // 
            this.firstTimer.Enabled = true;
            this.firstTimer.Interval = 150;
            this.firstTimer.Tick += new System.EventHandler(this.firstTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(234, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 94);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // TutFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(299, 390);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MoblevelLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.healButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.MonsterMp);
            this.Controls.Add(this.MonsterHp);
            this.Controls.Add(this.Punchbutton);
            this.Controls.Add(this.PlayerMp);
            this.Controls.Add(this.PlayerHp);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.Monster);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TutFight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Fight1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Monster;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Label PlayerHp;
        private System.Windows.Forms.Label PlayerMp;
        private System.Windows.Forms.Button Punchbutton;
        private System.Windows.Forms.Label MonsterMp;
        private System.Windows.Forms.Label MonsterHp;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Timer punchTimer;
        private System.Windows.Forms.Timer battleTimer;
        private System.Windows.Forms.Timer mobAttackTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button healButton;
        private System.Windows.Forms.Timer winTimer;
        private System.Windows.Forms.Timer healTimer;
        private System.Windows.Forms.Label MoblevelLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer firstTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}