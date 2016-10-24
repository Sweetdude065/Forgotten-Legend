namespace Forgotten_Legend
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            this.mainComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.offComboBox = new System.Windows.Forms.ComboBox();
            this.headComboBox = new System.Windows.Forms.ComboBox();
            this.bodyComboBox = new System.Windows.Forms.ComboBox();
            this.legsComboBox = new System.Windows.Forms.ComboBox();
            this.shoeComboBox = new System.Windows.Forms.ComboBox();
            this.neckComboBox = new System.Windows.Forms.ComboBox();
            this.ringComboBox = new System.Windows.Forms.ComboBox();
            this.petComboBox = new System.Windows.Forms.ComboBox();
            this.actionUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.constTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainComboBox
            // 
            this.mainComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainComboBox.FormattingEnabled = true;
            this.mainComboBox.Items.AddRange(new object[] {
            "(None)",
            "Broken Wooden Sword"});
            this.mainComboBox.Location = new System.Drawing.Point(12, 12);
            this.mainComboBox.Name = "mainComboBox";
            this.mainComboBox.Size = new System.Drawing.Size(137, 21);
            this.mainComboBox.Sorted = true;
            this.mainComboBox.TabIndex = 0;
            this.mainComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "- Main Hand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(155, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "- Offhand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(155, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "- Head";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(155, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "- Body";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(155, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "- Legs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(155, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "- Shoes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(156, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "- Necklace";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(156, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "- Ring";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(156, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "- Pet";
            // 
            // offComboBox
            // 
            this.offComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.offComboBox.FormattingEnabled = true;
            this.offComboBox.Items.AddRange(new object[] {
            "(None)"});
            this.offComboBox.Location = new System.Drawing.Point(12, 39);
            this.offComboBox.Name = "offComboBox";
            this.offComboBox.Size = new System.Drawing.Size(137, 21);
            this.offComboBox.Sorted = true;
            this.offComboBox.TabIndex = 18;
            // 
            // headComboBox
            // 
            this.headComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.headComboBox.FormattingEnabled = true;
            this.headComboBox.Items.AddRange(new object[] {
            "(None)"});
            this.headComboBox.Location = new System.Drawing.Point(12, 66);
            this.headComboBox.Name = "headComboBox";
            this.headComboBox.Size = new System.Drawing.Size(137, 21);
            this.headComboBox.Sorted = true;
            this.headComboBox.TabIndex = 19;
            this.headComboBox.SelectedIndexChanged += new System.EventHandler(this.HeadComboBox_SelectedIndexChanged);
            // 
            // bodyComboBox
            // 
            this.bodyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bodyComboBox.FormattingEnabled = true;
            this.bodyComboBox.Items.AddRange(new object[] {
            "(None)"});
            this.bodyComboBox.Location = new System.Drawing.Point(12, 93);
            this.bodyComboBox.Name = "bodyComboBox";
            this.bodyComboBox.Size = new System.Drawing.Size(136, 21);
            this.bodyComboBox.Sorted = true;
            this.bodyComboBox.TabIndex = 20;
            this.bodyComboBox.SelectedIndexChanged += new System.EventHandler(this.bodyComboBox_SelectedIndexChanged);
            // 
            // legsComboBox
            // 
            this.legsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.legsComboBox.FormattingEnabled = true;
            this.legsComboBox.Items.AddRange(new object[] {
            "(None)"});
            this.legsComboBox.Location = new System.Drawing.Point(12, 121);
            this.legsComboBox.Name = "legsComboBox";
            this.legsComboBox.Size = new System.Drawing.Size(136, 21);
            this.legsComboBox.Sorted = true;
            this.legsComboBox.TabIndex = 21;
            this.legsComboBox.SelectedIndexChanged += new System.EventHandler(this.legsComboBox_SelectedIndexChanged);
            // 
            // shoeComboBox
            // 
            this.shoeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shoeComboBox.FormattingEnabled = true;
            this.shoeComboBox.Items.AddRange(new object[] {
            "(None)"});
            this.shoeComboBox.Location = new System.Drawing.Point(12, 149);
            this.shoeComboBox.Name = "shoeComboBox";
            this.shoeComboBox.Size = new System.Drawing.Size(136, 21);
            this.shoeComboBox.Sorted = true;
            this.shoeComboBox.TabIndex = 22;
            this.shoeComboBox.SelectedIndexChanged += new System.EventHandler(this.shoeComboBox_SelectedIndexChanged);
            // 
            // neckComboBox
            // 
            this.neckComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.neckComboBox.FormattingEnabled = true;
            this.neckComboBox.Items.AddRange(new object[] {
            "(None)"});
            this.neckComboBox.Location = new System.Drawing.Point(13, 177);
            this.neckComboBox.Name = "neckComboBox";
            this.neckComboBox.Size = new System.Drawing.Size(136, 21);
            this.neckComboBox.Sorted = true;
            this.neckComboBox.TabIndex = 23;
            // 
            // ringComboBox
            // 
            this.ringComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ringComboBox.FormattingEnabled = true;
            this.ringComboBox.Items.AddRange(new object[] {
            "(None)"});
            this.ringComboBox.Location = new System.Drawing.Point(12, 205);
            this.ringComboBox.Name = "ringComboBox";
            this.ringComboBox.Size = new System.Drawing.Size(136, 21);
            this.ringComboBox.Sorted = true;
            this.ringComboBox.TabIndex = 24;
            this.ringComboBox.SelectedIndexChanged += new System.EventHandler(this.ringComboBox_SelectedIndexChanged);
            // 
            // petComboBox
            // 
            this.petComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.petComboBox.FormattingEnabled = true;
            this.petComboBox.Items.AddRange(new object[] {
            "(None)"});
            this.petComboBox.Location = new System.Drawing.Point(13, 232);
            this.petComboBox.Name = "petComboBox";
            this.petComboBox.Size = new System.Drawing.Size(136, 21);
            this.petComboBox.Sorted = true;
            this.petComboBox.TabIndex = 25;
            // 
            // actionUpdateTimer
            // 
            this.actionUpdateTimer.Enabled = true;
            this.actionUpdateTimer.Interval = 10;
            this.actionUpdateTimer.Tick += new System.EventHandler(this.actionUpdateTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(219, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 182);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // constTimer
            // 
            this.constTimer.Interval = 1;
            this.constTimer.Tick += new System.EventHandler(this.constTimer_Tick);
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(328, 262);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.petComboBox);
            this.Controls.Add(this.ringComboBox);
            this.Controls.Add(this.neckComboBox);
            this.Controls.Add(this.shoeComboBox);
            this.Controls.Add(this.legsComboBox);
            this.Controls.Add(this.bodyComboBox);
            this.Controls.Add(this.headComboBox);
            this.Controls.Add(this.offComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Equipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.Equipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox mainComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox offComboBox;
        private System.Windows.Forms.ComboBox headComboBox;
        private System.Windows.Forms.ComboBox bodyComboBox;
        private System.Windows.Forms.ComboBox legsComboBox;
        private System.Windows.Forms.ComboBox shoeComboBox;
        private System.Windows.Forms.ComboBox neckComboBox;
        private System.Windows.Forms.ComboBox ringComboBox;
        private System.Windows.Forms.ComboBox petComboBox;
        private System.Windows.Forms.Timer actionUpdateTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer constTimer;
    }
}