namespace Mtg
{
    partial class RocksDorks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RocksDorks));
            this.BtnInvia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBDaul = new System.Windows.Forms.CheckBox();
            this.CBCommander = new System.Windows.Forms.CheckBox();
            this.CBShock = new System.Windows.Forms.CheckBox();
            this.CBVivid = new System.Windows.Forms.CheckBox();
            this.CBTriome = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.CBPain = new System.Windows.Forms.CheckBox();
            this.CBPathway = new System.Windows.Forms.CheckBox();
            this.CBScry = new System.Windows.Forms.CheckBox();
            this.GBselect = new System.Windows.Forms.GroupBox();
            this.RBnessuno = new System.Windows.Forms.RadioButton();
            this.RBtutti = new System.Windows.Forms.RadioButton();
            this.CB1mana = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.GBselect.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnInvia
            // 
            this.BtnInvia.BackColor = System.Drawing.SystemColors.Control;
            this.BtnInvia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnInvia.BackgroundImage")));
            this.BtnInvia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInvia.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInvia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnInvia.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnInvia.Location = new System.Drawing.Point(429, 488);
            this.BtnInvia.Margin = new System.Windows.Forms.Padding(70, 3, 3, 3);
            this.BtnInvia.Name = "BtnInvia";
            this.BtnInvia.Padding = new System.Windows.Forms.Padding(10);
            this.BtnInvia.Size = new System.Drawing.Size(195, 83);
            this.BtnInvia.TabIndex = 77;
            this.BtnInvia.Text = "Metti";
            this.BtnInvia.UseVisualStyleBackColor = false;
            this.BtnInvia.Click += new System.EventHandler(this.BtnInvia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CB1mana);
            this.groupBox1.Controls.Add(this.CBDaul);
            this.groupBox1.Controls.Add(this.CBCommander);
            this.groupBox1.Controls.Add(this.CBShock);
            this.groupBox1.Controls.Add(this.CBVivid);
            this.groupBox1.Controls.Add(this.CBTriome);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.CBPain);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 470);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            // 
            // CBDaul
            // 
            this.CBDaul.BackColor = System.Drawing.Color.Red;
            this.CBDaul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CBDaul.BackgroundImage")));
            this.CBDaul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CBDaul.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBDaul.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDaul.ForeColor = System.Drawing.Color.Red;
            this.CBDaul.Location = new System.Drawing.Point(162, 49);
            this.CBDaul.Name = "CBDaul";
            this.CBDaul.Size = new System.Drawing.Size(152, 202);
            this.CBDaul.TabIndex = 4;
            this.CBDaul.Text = "Talisman";
            this.CBDaul.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBDaul.UseVisualStyleBackColor = false;
            this.CBDaul.Click += new System.EventHandler(this.CBCommander_Click);
            // 
            // CBCommander
            // 
            this.CBCommander.BackColor = System.Drawing.Color.Green;
            this.CBCommander.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CBCommander.BackgroundImage")));
            this.CBCommander.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CBCommander.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBCommander.Checked = true;
            this.CBCommander.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBCommander.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCommander.ForeColor = System.Drawing.Color.Green;
            this.CBCommander.Location = new System.Drawing.Point(8, 49);
            this.CBCommander.Name = "CBCommander";
            this.CBCommander.Size = new System.Drawing.Size(152, 202);
            this.CBCommander.TabIndex = 17;
            this.CBCommander.Text = "Signet";
            this.CBCommander.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBCommander.UseVisualStyleBackColor = false;
            this.CBCommander.Click += new System.EventHandler(this.CBCommander_Click);
            // 
            // CBShock
            // 
            this.CBShock.BackColor = System.Drawing.Color.Red;
            this.CBShock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CBShock.BackgroundImage")));
            this.CBShock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CBShock.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBShock.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBShock.ForeColor = System.Drawing.Color.Red;
            this.CBShock.Location = new System.Drawing.Point(474, 49);
            this.CBShock.Name = "CBShock";
            this.CBShock.Size = new System.Drawing.Size(152, 202);
            this.CBShock.TabIndex = 5;
            this.CBShock.Text = "Diamonds";
            this.CBShock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBShock.UseVisualStyleBackColor = false;
            this.CBShock.Click += new System.EventHandler(this.CBCommander_Click);
            // 
            // CBVivid
            // 
            this.CBVivid.BackColor = System.Drawing.Color.Red;
            this.CBVivid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CBVivid.BackgroundImage")));
            this.CBVivid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CBVivid.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBVivid.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBVivid.ForeColor = System.Drawing.Color.Red;
            this.CBVivid.Location = new System.Drawing.Point(162, 256);
            this.CBVivid.Name = "CBVivid";
            this.CBVivid.Size = new System.Drawing.Size(152, 202);
            this.CBVivid.TabIndex = 16;
            this.CBVivid.Text = "Monuments";
            this.CBVivid.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBVivid.UseVisualStyleBackColor = false;
            this.CBVivid.Click += new System.EventHandler(this.CBCommander_Click);
            // 
            // CBTriome
            // 
            this.CBTriome.BackColor = System.Drawing.Color.Red;
            this.CBTriome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CBTriome.BackgroundImage")));
            this.CBTriome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CBTriome.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBTriome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTriome.ForeColor = System.Drawing.Color.Red;
            this.CBTriome.Location = new System.Drawing.Point(316, 256);
            this.CBTriome.Name = "CBTriome";
            this.CBTriome.Size = new System.Drawing.Size(152, 202);
            this.CBTriome.TabIndex = 6;
            this.CBTriome.Text = "Ramos";
            this.CBTriome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBTriome.UseVisualStyleBackColor = false;
            this.CBTriome.Click += new System.EventHandler(this.CBCommander_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.BackColor = System.Drawing.Color.Red;
            this.checkBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox4.BackgroundImage")));
            this.checkBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.Red;
            this.checkBox4.Location = new System.Drawing.Point(318, 49);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(152, 202);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "2ManaAllColor";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.Click += new System.EventHandler(this.CBCommander_Click);
            // 
            // CBPain
            // 
            this.CBPain.BackColor = System.Drawing.Color.Red;
            this.CBPain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CBPain.BackgroundImage")));
            this.CBPain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CBPain.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBPain.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPain.ForeColor = System.Drawing.Color.Red;
            this.CBPain.Location = new System.Drawing.Point(8, 256);
            this.CBPain.Name = "CBPain";
            this.CBPain.Size = new System.Drawing.Size(152, 202);
            this.CBPain.TabIndex = 9;
            this.CBPain.Text = "2ManaColorless";
            this.CBPain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBPain.UseVisualStyleBackColor = false;
            this.CBPain.Click += new System.EventHandler(this.CBCommander_Click);
            // 
            // CBPathway
            // 
            this.CBPathway.BackColor = System.Drawing.Color.Green;
            this.CBPathway.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CBPathway.BackgroundImage")));
            this.CBPathway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CBPathway.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBPathway.Checked = true;
            this.CBPathway.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBPathway.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPathway.ForeColor = System.Drawing.Color.Green;
            this.CBPathway.Location = new System.Drawing.Point(11, 50);
            this.CBPathway.Name = "CBPathway";
            this.CBPathway.Size = new System.Drawing.Size(152, 202);
            this.CBPathway.TabIndex = 10;
            this.CBPathway.Text = "AllColor";
            this.CBPathway.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBPathway.UseVisualStyleBackColor = false;
            this.CBPathway.Click += new System.EventHandler(this.CBCommander_Click);
            // 
            // CBScry
            // 
            this.CBScry.BackColor = System.Drawing.Color.Red;
            this.CBScry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CBScry.BackgroundImage")));
            this.CBScry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CBScry.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBScry.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBScry.ForeColor = System.Drawing.Color.Red;
            this.CBScry.Location = new System.Drawing.Point(11, 258);
            this.CBScry.Name = "CBScry";
            this.CBScry.Size = new System.Drawing.Size(152, 202);
            this.CBScry.TabIndex = 11;
            this.CBScry.Text = "Colorless  && One-color";
            this.CBScry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CBScry.UseVisualStyleBackColor = false;
            this.CBScry.Click += new System.EventHandler(this.CBCommander_Click);
            // 
            // GBselect
            // 
            this.GBselect.Controls.Add(this.RBnessuno);
            this.GBselect.Controls.Add(this.RBtutti);
            this.GBselect.Location = new System.Drawing.Point(244, 488);
            this.GBselect.Name = "GBselect";
            this.GBselect.Size = new System.Drawing.Size(179, 83);
            this.GBselect.TabIndex = 79;
            this.GBselect.TabStop = false;
            this.GBselect.Text = "Seleziona:";
            // 
            // RBnessuno
            // 
            this.RBnessuno.AutoSize = true;
            this.RBnessuno.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBnessuno.Location = new System.Drawing.Point(6, 42);
            this.RBnessuno.Name = "RBnessuno";
            this.RBnessuno.Size = new System.Drawing.Size(85, 21);
            this.RBnessuno.TabIndex = 74;
            this.RBnessuno.TabStop = true;
            this.RBnessuno.Text = "Nessuno";
            this.RBnessuno.UseVisualStyleBackColor = true;
            this.RBnessuno.CheckedChanged += new System.EventHandler(this.RBnessuno_CheckedChanged);
            // 
            // RBtutti
            // 
            this.RBtutti.AutoSize = true;
            this.RBtutti.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtutti.Location = new System.Drawing.Point(6, 19);
            this.RBtutti.Name = "RBtutti";
            this.RBtutti.Size = new System.Drawing.Size(60, 21);
            this.RBtutti.TabIndex = 75;
            this.RBtutti.TabStop = true;
            this.RBtutti.Text = "Tutti";
            this.RBtutti.UseVisualStyleBackColor = true;
            this.RBtutti.CheckedChanged += new System.EventHandler(this.RBtutti_CheckedChanged);
            // 
            // CB1mana
            // 
            this.CB1mana.BackColor = System.Drawing.Color.Red;
            this.CB1mana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CB1mana.BackgroundImage")));
            this.CB1mana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CB1mana.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CB1mana.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB1mana.ForeColor = System.Drawing.Color.Red;
            this.CB1mana.Location = new System.Drawing.Point(474, 257);
            this.CB1mana.Name = "CB1mana";
            this.CB1mana.Size = new System.Drawing.Size(152, 202);
            this.CB1mana.TabIndex = 18;
            this.CB1mana.Text = "1Mana";
            this.CB1mana.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CB1mana.UseVisualStyleBackColor = false;
            this.CB1mana.Click += new System.EventHandler(this.CBCommander_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "DORKS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(233, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "MANA ROCKS";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CBScry);
            this.groupBox2.Controls.Add(this.CBPathway);
            this.groupBox2.Location = new System.Drawing.Point(656, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 470);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            // 
            // RocksDorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Controls.Add(this.BtnInvia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBselect);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RocksDorks";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RocksDorks";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RocksDorks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBselect.ResumeLayout(false);
            this.GBselect.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInvia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CBDaul;
        private System.Windows.Forms.CheckBox CBCommander;
        private System.Windows.Forms.CheckBox CBShock;
        private System.Windows.Forms.CheckBox CBVivid;
        private System.Windows.Forms.CheckBox CBTriome;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox CBPain;
        private System.Windows.Forms.CheckBox CBPathway;
        private System.Windows.Forms.CheckBox CBScry;
        private System.Windows.Forms.GroupBox GBselect;
        private System.Windows.Forms.RadioButton RBnessuno;
        private System.Windows.Forms.RadioButton RBtutti;
        private System.Windows.Forms.CheckBox CB1mana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}