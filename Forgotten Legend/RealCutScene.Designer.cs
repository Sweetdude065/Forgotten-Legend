namespace Forgotten_Legend
{
    partial class RealCutScene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealCutScene));
            this.talkButton2 = new System.Windows.Forms.Button();
            this.talkButton1 = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.talkButton3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.talkButton4 = new System.Windows.Forms.Button();
            this.talkButton5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.talkButton1o2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // talkButton2
            // 
            this.talkButton2.Location = new System.Drawing.Point(128, 240);
            this.talkButton2.Name = "talkButton2";
            this.talkButton2.Size = new System.Drawing.Size(110, 23);
            this.talkButton2.TabIndex = 12;
            this.talkButton2.Text = "I was a fighter?";
            this.talkButton2.UseVisualStyleBackColor = true;
            this.talkButton2.Visible = false;
            this.talkButton2.Click += new System.EventHandler(this.talkButton2_Click);
            // 
            // talkButton1
            // 
            this.talkButton1.Location = new System.Drawing.Point(12, 240);
            this.talkButton1.Name = "talkButton1";
            this.talkButton1.Size = new System.Drawing.Size(110, 23);
            this.talkButton1.TabIndex = 11;
            this.talkButton1.Text = "What is your name?";
            this.talkButton1.UseVisualStyleBackColor = true;
            this.talkButton1.Visible = false;
            this.talkButton1.Click += new System.EventHandler(this.talkButton1_Click);
            // 
            // skipButton
            // 
            this.skipButton.Location = new System.Drawing.Point(128, 359);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(110, 23);
            this.skipButton.TabIndex = 10;
            this.skipButton.Text = "End Conversation";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Visible = false;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // talkButton3
            // 
            this.talkButton3.Location = new System.Drawing.Point(12, 299);
            this.talkButton3.Name = "talkButton3";
            this.talkButton3.Size = new System.Drawing.Size(110, 23);
            this.talkButton3.TabIndex = 9;
            this.talkButton3.Text = "Why am I here?";
            this.talkButton3.UseVisualStyleBackColor = true;
            this.talkButton3.Visible = false;
            this.talkButton3.Click += new System.EventHandler(this.talkButton3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Location = new System.Drawing.Point(12, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(226, 215);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // talkButton4
            // 
            this.talkButton4.Location = new System.Drawing.Point(128, 299);
            this.talkButton4.Name = "talkButton4";
            this.talkButton4.Size = new System.Drawing.Size(110, 23);
            this.talkButton4.TabIndex = 13;
            this.talkButton4.Text = "Can you help fight?";
            this.talkButton4.UseVisualStyleBackColor = true;
            this.talkButton4.Visible = false;
            this.talkButton4.Click += new System.EventHandler(this.talkButton4_Click);
            // 
            // talkButton5
            // 
            this.talkButton5.Location = new System.Drawing.Point(12, 359);
            this.talkButton5.Name = "talkButton5";
            this.talkButton5.Size = new System.Drawing.Size(110, 23);
            this.talkButton5.TabIndex = 14;
            this.talkButton5.UseVisualStyleBackColor = true;
            this.talkButton5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Press Enter to &Skip";
            // 
            // talkButton1o2
            // 
            this.talkButton1o2.Location = new System.Drawing.Point(12, 240);
            this.talkButton1o2.Name = "talkButton1o2";
            this.talkButton1o2.Size = new System.Drawing.Size(110, 23);
            this.talkButton1o2.TabIndex = 16;
            this.talkButton1o2.Text = "Nice name";
            this.talkButton1o2.UseVisualStyleBackColor = true;
            this.talkButton1o2.Visible = false;
            this.talkButton1o2.Click += new System.EventHandler(this.talkButton1o2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RealCutScene
            // 
            this.AcceptButton = this.skipButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(250, 394);
            this.ControlBox = false;
            this.Controls.Add(this.talkButton1o2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.talkButton5);
            this.Controls.Add(this.talkButton4);
            this.Controls.Add(this.talkButton2);
            this.Controls.Add(this.talkButton1);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.talkButton3);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RealCutScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RealCutScene_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button talkButton2;
        private System.Windows.Forms.Button talkButton1;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button talkButton3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button talkButton4;
        private System.Windows.Forms.Button talkButton5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button talkButton1o2;
        private System.Windows.Forms.Timer timer1;
    }
}