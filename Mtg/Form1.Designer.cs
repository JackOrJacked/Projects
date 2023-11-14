namespace Mtg
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Btn_calculate = new System.Windows.Forms.Button();
            this.txtDeck = new System.Windows.Forms.TextBox();
            this.txtHand = new System.Windows.Forms.TextBox();
            this.txtsucc = new System.Windows.Forms.TextBox();
            this.txtci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.awd = new System.Windows.Forms.Label();
            this.lblprec = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCreaTag = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnImportaFile = new System.Windows.Forms.Button();
            this.lblTotalTags2 = new System.Windows.Forms.Label();
            this.lblDeck = new System.Windows.Forms.Label();
            this.FlpOpzioniDeck = new System.Windows.Forms.FlowLayoutPanel();
            this.CBSelezioneMultipla = new System.Windows.Forms.CheckBox();
            this.CbColori = new System.Windows.Forms.CheckBox();
            this.btnCopia = new System.Windows.Forms.Button();
            this.BtnStampa = new System.Windows.Forms.Button();
            this.BtnMox = new System.Windows.Forms.Button();
            this.BtnSaveFile = new System.Windows.Forms.Button();
            this.btnClip = new System.Windows.Forms.Button();
            this.lvDeck = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDarkMode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbDrag = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblicoloridentity = new System.Windows.Forms.Label();
            this.cbW = new System.Windows.Forms.CheckBox();
            this.cbU = new System.Windows.Forms.CheckBox();
            this.cbB = new System.Windows.Forms.CheckBox();
            this.cbR = new System.Windows.Forms.CheckBox();
            this.cbG = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDorks = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.FLPCharts = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.LblTot = new System.Windows.Forms.Label();
            this.lblTotalTags = new System.Windows.Forms.Label();
            this.pictureBox1 = new Mtg.ResizablePictureBox();
            this.groupBox1.SuspendLayout();
            this.FlpOpzioniDeck.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel2.SuspendLayout();
            this.FLPCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_calculate
            // 
            this.Btn_calculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_calculate.BackgroundImage")));
            this.Btn_calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_calculate.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_calculate.Location = new System.Drawing.Point(232, 15);
            this.Btn_calculate.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_calculate.Name = "Btn_calculate";
            this.Btn_calculate.Size = new System.Drawing.Size(95, 76);
            this.Btn_calculate.TabIndex = 0;
            this.Btn_calculate.Text = "Calcola";
            this.Btn_calculate.UseVisualStyleBackColor = true;
            this.Btn_calculate.Click += new System.EventHandler(this.Btn_calculate_Click);
            // 
            // txtDeck
            // 
            this.txtDeck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.txtDeck.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDeck.Location = new System.Drawing.Point(17, 13);
            this.txtDeck.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeck.Name = "txtDeck";
            this.txtDeck.Size = new System.Drawing.Size(76, 20);
            this.txtDeck.TabIndex = 1;
            this.txtDeck.Text = "99";
            this.toolTip1.SetToolTip(this.txtDeck, "carte nel mazzo");
            this.txtDeck.TextChanged += new System.EventHandler(this.txtsucc_TextChanged);
            // 
            // txtHand
            // 
            this.txtHand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.txtHand.ForeColor = System.Drawing.SystemColors.Control;
            this.txtHand.Location = new System.Drawing.Point(17, 36);
            this.txtHand.Margin = new System.Windows.Forms.Padding(2);
            this.txtHand.Name = "txtHand";
            this.txtHand.Size = new System.Drawing.Size(76, 20);
            this.txtHand.TabIndex = 2;
            this.txtHand.Text = "7";
            this.toolTip1.SetToolTip(this.txtHand, "carte in mano iniziale");
            this.txtHand.TextChanged += new System.EventHandler(this.txtsucc_TextChanged);
            // 
            // txtsucc
            // 
            this.txtsucc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.txtsucc.ForeColor = System.Drawing.SystemColors.Control;
            this.txtsucc.Location = new System.Drawing.Point(17, 83);
            this.txtsucc.Margin = new System.Windows.Forms.Padding(2);
            this.txtsucc.Name = "txtsucc";
            this.txtsucc.Size = new System.Drawing.Size(76, 20);
            this.txtsucc.TabIndex = 4;
            this.txtsucc.Text = "1";
            this.toolTip1.SetToolTip(this.txtsucc, "numero carte che vorresti vedere in mano");
            this.txtsucc.TextChanged += new System.EventHandler(this.txtsucc_TextChanged);
            this.txtsucc.MouseEnter += new System.EventHandler(this.txtsucc_MouseEnter);
            // 
            // txtci
            // 
            this.txtci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.txtci.ForeColor = System.Drawing.SystemColors.Control;
            this.txtci.Location = new System.Drawing.Point(17, 60);
            this.txtci.Margin = new System.Windows.Forms.Padding(2);
            this.txtci.Name = "txtci";
            this.txtci.Size = new System.Drawing.Size(76, 20);
            this.txtci.TabIndex = 3;
            this.txtci.Text = "10";
            this.toolTip1.SetToolTip(this.txtci, "numero carte che nel mazzo vorresti trovare");
            this.txtci.MouseEnter += new System.EventHandler(this.txtci_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(528, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "%";
            // 
            // lbldisplay
            // 
            this.lbldisplay.AutoSize = true;
            this.lbldisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.lbldisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.lbldisplay.Location = new System.Drawing.Point(489, 72);
            this.lbldisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(37, 13);
            this.lbldisplay.TabIndex = 6;
            this.lbldisplay.Text = "_____";
            this.lbldisplay.MouseEnter += new System.EventHandler(this.lbldisplay_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(97, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mano iniziale ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(97, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mazzo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(97, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quante carte voglio";
            this.toolTip1.SetToolTip(this.label5, "numero carte che vorresti vedere in mano");
            this.label5.MouseEnter += new System.EventHandler(this.txtsucc_MouseEnter);
            // 
            // awd
            // 
            this.awd.AutoSize = true;
            this.awd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.awd.ForeColor = System.Drawing.SystemColors.Control;
            this.awd.Location = new System.Drawing.Point(97, 62);
            this.awd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.awd.Name = "awd";
            this.awd.Size = new System.Drawing.Size(86, 13);
            this.awd.TabIndex = 9;
            this.awd.Text = "Carte interessate";
            this.toolTip1.SetToolTip(this.awd, "numero carte che nel mazzo vorresti trovare");
            this.awd.MouseEnter += new System.EventHandler(this.txtci_MouseEnter);
            // 
            // lblprec
            // 
            this.lblprec.AutoSize = true;
            this.lblprec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.lblprec.ForeColor = System.Drawing.SystemColors.Control;
            this.lblprec.Location = new System.Drawing.Point(489, 36);
            this.lblprec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblprec.Name = "lblprec";
            this.lblprec.Size = new System.Drawing.Size(37, 13);
            this.lblprec.TabIndex = 11;
            this.lblprec.Text = "_____";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(528, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(334, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Esattamente il numero di carte\r\n che voglio";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(363, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Almeno quelle carte";
            this.label8.MouseEnter += new System.EventHandler(this.lbldisplay_MouseEnter);
            // 
            // TxtInfo
            // 
            this.TxtInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.TxtInfo.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TxtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfo.ForeColor = System.Drawing.Color.White;
            this.TxtInfo.Location = new System.Drawing.Point(8, 108);
            this.TxtInfo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtInfo.MinimumSize = new System.Drawing.Size(0, 50);
            this.TxtInfo.Multiline = true;
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.ReadOnly = true;
            this.TxtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtInfo.Size = new System.Drawing.Size(527, 54);
            this.TxtInfo.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(9, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 41);
            this.textBox1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(102, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "<Aggiungi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCreaTag
            // 
            this.BtnCreaTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreaTag.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCreaTag.Image = ((System.Drawing.Image)(resources.GetObject("BtnCreaTag.Image")));
            this.BtnCreaTag.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnCreaTag.Location = new System.Drawing.Point(2, 29);
            this.BtnCreaTag.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreaTag.Name = "BtnCreaTag";
            this.BtnCreaTag.Size = new System.Drawing.Size(515, 44);
            this.BtnCreaTag.TabIndex = 19;
            this.BtnCreaTag.Text = "Aggiungi Tag";
            this.BtnCreaTag.UseVisualStyleBackColor = true;
            this.BtnCreaTag.Click += new System.EventHandler(this.CreaTag_Click);
            this.BtnCreaTag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvDeck_KeyPress);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(377, 17);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 40);
            this.button3.TabIndex = 47;
            this.button3.Text = "pulisci lista";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button4.Location = new System.Drawing.Point(14, 163);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(515, 44);
            this.button4.TabIndex = 56;
            this.button4.Text = "Deck tag";
            this.toolTip1.SetToolTip(this.button4, "Mostra menù deck");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvDeck_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnImportaFile);
            this.groupBox1.Controls.Add(this.lblTotalTags2);
            this.groupBox1.Controls.Add(this.lblDeck);
            this.groupBox1.Controls.Add(this.FlpOpzioniDeck);
            this.groupBox1.Controls.Add(this.btnClip);
            this.groupBox1.Controls.Add(this.lvDeck);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(8, 207);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(535, 592);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // BtnImportaFile
            // 
            this.BtnImportaFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnImportaFile.BackgroundImage")));
            this.BtnImportaFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnImportaFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportaFile.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnImportaFile.Location = new System.Drawing.Point(192, 17);
            this.BtnImportaFile.Margin = new System.Windows.Forms.Padding(2);
            this.BtnImportaFile.Name = "BtnImportaFile";
            this.BtnImportaFile.Size = new System.Drawing.Size(82, 40);
            this.BtnImportaFile.TabIndex = 76;
            this.BtnImportaFile.Text = "importa File";
            this.BtnImportaFile.UseVisualStyleBackColor = true;
            this.BtnImportaFile.Click += new System.EventHandler(this.BtnImportaFile_Click);
            // 
            // lblTotalTags2
            // 
            this.lblTotalTags2.AutoSize = true;
            this.lblTotalTags2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTotalTags2.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTotalTags2.Location = new System.Drawing.Point(514, 43);
            this.lblTotalTags2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalTags2.Name = "lblTotalTags2";
            this.lblTotalTags2.Size = new System.Drawing.Size(13, 13);
            this.lblTotalTags2.TabIndex = 74;
            this.lblTotalTags2.Text = "0";
            // 
            // lblDeck
            // 
            this.lblDeck.BackColor = System.Drawing.Color.Teal;
            this.lblDeck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeck.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblDeck.Location = new System.Drawing.Point(491, 18);
            this.lblDeck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(35, 39);
            this.lblDeck.TabIndex = 75;
            this.lblDeck.Text = "0";
            this.lblDeck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlpOpzioniDeck
            // 
            this.FlpOpzioniDeck.Controls.Add(this.CBSelezioneMultipla);
            this.FlpOpzioniDeck.Controls.Add(this.CbColori);
            this.FlpOpzioniDeck.Controls.Add(this.BtnCreaTag);
            this.FlpOpzioniDeck.Controls.Add(this.btnCopia);
            this.FlpOpzioniDeck.Controls.Add(this.BtnStampa);
            this.FlpOpzioniDeck.Controls.Add(this.BtnMox);
            this.FlpOpzioniDeck.Controls.Add(this.BtnSaveFile);
            this.FlpOpzioniDeck.Location = new System.Drawing.Point(5, 470);
            this.FlpOpzioniDeck.Margin = new System.Windows.Forms.Padding(2);
            this.FlpOpzioniDeck.Name = "FlpOpzioniDeck";
            this.FlpOpzioniDeck.Size = new System.Drawing.Size(525, 333);
            this.FlpOpzioniDeck.TabIndex = 74;
            // 
            // CBSelezioneMultipla
            // 
            this.CBSelezioneMultipla.BackColor = System.Drawing.Color.DarkGreen;
            this.CBSelezioneMultipla.Checked = true;
            this.CBSelezioneMultipla.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBSelezioneMultipla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSelezioneMultipla.ForeColor = System.Drawing.SystemColors.Control;
            this.CBSelezioneMultipla.Location = new System.Drawing.Point(2, 2);
            this.CBSelezioneMultipla.Margin = new System.Windows.Forms.Padding(2);
            this.CBSelezioneMultipla.Name = "CBSelezioneMultipla";
            this.CBSelezioneMultipla.Size = new System.Drawing.Size(237, 23);
            this.CBSelezioneMultipla.TabIndex = 66;
            this.CBSelezioneMultipla.Text = "Selezione Multipla";
            this.CBSelezioneMultipla.UseVisualStyleBackColor = false;
            this.CBSelezioneMultipla.CheckedChanged += new System.EventHandler(this.CBSelezioneMultipla_CheckedChanged);
            // 
            // CbColori
            // 
            this.CbColori.BackColor = System.Drawing.Color.DarkRed;
            this.CbColori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbColori.ForeColor = System.Drawing.SystemColors.Control;
            this.CbColori.Location = new System.Drawing.Point(243, 2);
            this.CbColori.Margin = new System.Windows.Forms.Padding(2);
            this.CbColori.Name = "CbColori";
            this.CbColori.Size = new System.Drawing.Size(271, 23);
            this.CbColori.TabIndex = 65;
            this.CbColori.Text = "Analizza Colori";
            this.CbColori.UseVisualStyleBackColor = false;
            this.CbColori.CheckedChanged += new System.EventHandler(this.CbColori_CheckedChanged);
            // 
            // btnCopia
            // 
            this.btnCopia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopia.BackgroundImage")));
            this.btnCopia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopia.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCopia.Location = new System.Drawing.Point(2, 77);
            this.btnCopia.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopia.Name = "btnCopia";
            this.btnCopia.Size = new System.Drawing.Size(124, 43);
            this.btnCopia.TabIndex = 48;
            this.btnCopia.Text = "Copia negli appunti";
            this.btnCopia.UseVisualStyleBackColor = true;
            this.btnCopia.Click += new System.EventHandler(this.btnCopia_Click);
            // 
            // BtnStampa
            // 
            this.BtnStampa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStampa.BackgroundImage")));
            this.BtnStampa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStampa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStampa.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnStampa.Location = new System.Drawing.Point(130, 77);
            this.BtnStampa.Margin = new System.Windows.Forms.Padding(2);
            this.BtnStampa.Name = "BtnStampa";
            this.BtnStampa.Size = new System.Drawing.Size(124, 43);
            this.BtnStampa.TabIndex = 72;
            this.BtnStampa.Text = "Stampa";
            this.BtnStampa.UseVisualStyleBackColor = true;
            this.BtnStampa.Click += new System.EventHandler(this.BtnStampa_Click);
            // 
            // BtnMox
            // 
            this.BtnMox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMox.BackgroundImage")));
            this.BtnMox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMox.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnMox.Location = new System.Drawing.Point(258, 77);
            this.BtnMox.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMox.Name = "BtnMox";
            this.BtnMox.Size = new System.Drawing.Size(124, 43);
            this.BtnMox.TabIndex = 73;
            this.BtnMox.Text = "Vai su moxfield";
            this.BtnMox.UseVisualStyleBackColor = true;
            this.BtnMox.Click += new System.EventHandler(this.BtnMox_Click);
            // 
            // BtnSaveFile
            // 
            this.BtnSaveFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSaveFile.BackgroundImage")));
            this.BtnSaveFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveFile.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSaveFile.Location = new System.Drawing.Point(386, 77);
            this.BtnSaveFile.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSaveFile.Name = "BtnSaveFile";
            this.BtnSaveFile.Size = new System.Drawing.Size(128, 43);
            this.BtnSaveFile.TabIndex = 76;
            this.BtnSaveFile.Text = "Salva in file";
            this.BtnSaveFile.UseVisualStyleBackColor = true;
            this.BtnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // btnClip
            // 
            this.btnClip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClip.BackgroundImage")));
            this.btnClip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClip.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClip.Location = new System.Drawing.Point(278, 17);
            this.btnClip.Margin = new System.Windows.Forms.Padding(2);
            this.btnClip.Name = "btnClip";
            this.btnClip.Size = new System.Drawing.Size(94, 40);
            this.btnClip.TabIndex = 50;
            this.btnClip.Text = "importa da appunti";
            this.btnClip.UseVisualStyleBackColor = true;
            this.btnClip.Click += new System.EventHandler(this.btnClip_Click);
            this.btnClip.MouseEnter += new System.EventHandler(this.btnClip_MouseEnter);
            // 
            // lvDeck
            // 
            this.lvDeck.AllowDrop = true;
            this.lvDeck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.lvDeck.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvDeck.ForeColor = System.Drawing.SystemColors.Control;
            this.lvDeck.HideSelection = false;
            this.lvDeck.Location = new System.Drawing.Point(4, 65);
            this.lvDeck.Margin = new System.Windows.Forms.Padding(2);
            this.lvDeck.Name = "lvDeck";
            this.lvDeck.Size = new System.Drawing.Size(527, 401);
            this.lvDeck.TabIndex = 49;
            this.lvDeck.UseCompatibleStateImageBehavior = false;
            this.lvDeck.View = System.Windows.Forms.View.List;
            this.lvDeck.SelectedIndexChanged += new System.EventHandler(this.lvDeck_SelectedIndexChanged);
            this.lvDeck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvDeck_KeyPress);
            this.lvDeck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lv_MouseDown);
            this.lvDeck.MouseEnter += new System.EventHandler(this.lvDeck_MouseEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 140;
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDarkMode.BackgroundImage")));
            this.btnDarkMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDarkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarkMode.Location = new System.Drawing.Point(232, 4);
            this.btnDarkMode.Margin = new System.Windows.Forms.Padding(2);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(95, 27);
            this.btnDarkMode.TabIndex = 59;
            this.btnDarkMode.Text = "Darkmode";
            this.btnDarkMode.UseVisualStyleBackColor = true;
            this.btnDarkMode.Visible = false;
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.cbDrag);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(552, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 833);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(4, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 331);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // cbDrag
            // 
            this.cbDrag.AutoSize = true;
            this.cbDrag.Location = new System.Drawing.Point(8, 2);
            this.cbDrag.Margin = new System.Windows.Forms.Padding(2);
            this.cbDrag.Name = "cbDrag";
            this.cbDrag.Size = new System.Drawing.Size(135, 17);
            this.cbDrag.TabIndex = 74;
            this.cbDrag.Text = "Probabilità Trascinabile";
            this.cbDrag.UseVisualStyleBackColor = true;
            this.cbDrag.CheckedChanged += new System.EventHandler(this.Btn_calculate_Click);
            this.cbDrag.MouseEnter += new System.EventHandler(this.cbDrag_MouseEnter);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BorderlineColor = System.Drawing.Color.Maroon;
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            this.chart1.Cursor = System.Windows.Forms.Cursors.No;
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(17, 18);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(220, 310);
            this.chart1.TabIndex = 63;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            this.chart1.DoubleClick += new System.EventHandler(this.CbColori_CheckedChanged);
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FLPCharts_MouseClick);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart2.BorderlineColor = System.Drawing.Color.Maroon;
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            this.chart2.Cursor = System.Windows.Forms.Cursors.No;
            legend10.Name = "Legend1";
            this.chart2.Legends.Add(legend10);
            this.chart2.Location = new System.Drawing.Point(241, 18);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart2.Series.Add(series10);
            this.chart2.Size = new System.Drawing.Size(220, 310);
            this.chart2.TabIndex = 64;
            this.chart2.TabStop = false;
            this.chart2.Text = "chart2";
            this.chart2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FLPCharts_MouseClick);
            // 
            // lblicoloridentity
            // 
            this.lblicoloridentity.AutoSize = true;
            this.lblicoloridentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblicoloridentity.ForeColor = System.Drawing.SystemColors.Control;
            this.lblicoloridentity.Location = new System.Drawing.Point(8, 10);
            this.lblicoloridentity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblicoloridentity.Name = "lblicoloridentity";
            this.lblicoloridentity.Size = new System.Drawing.Size(205, 17);
            this.lblicoloridentity.TabIndex = 70;
            this.lblicoloridentity.Text = "Identità colore comandante";
            // 
            // cbW
            // 
            this.cbW.AutoSize = true;
            this.cbW.BackColor = System.Drawing.Color.Wheat;
            this.cbW.Checked = true;
            this.cbW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbW.Location = new System.Drawing.Point(239, 7);
            this.cbW.Margin = new System.Windows.Forms.Padding(2);
            this.cbW.Name = "cbW";
            this.cbW.Size = new System.Drawing.Size(37, 17);
            this.cbW.TabIndex = 65;
            this.cbW.Text = "W";
            this.cbW.UseVisualStyleBackColor = false;
            this.cbW.CheckedChanged += new System.EventHandler(this.CalcolaMostra);
            // 
            // cbU
            // 
            this.cbU.AutoSize = true;
            this.cbU.BackColor = System.Drawing.Color.Blue;
            this.cbU.Checked = true;
            this.cbU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbU.ForeColor = System.Drawing.SystemColors.Control;
            this.cbU.Location = new System.Drawing.Point(276, 7);
            this.cbU.Margin = new System.Windows.Forms.Padding(2);
            this.cbU.Name = "cbU";
            this.cbU.Size = new System.Drawing.Size(34, 17);
            this.cbU.TabIndex = 66;
            this.cbU.Text = "U";
            this.cbU.UseVisualStyleBackColor = false;
            this.cbU.CheckedChanged += new System.EventHandler(this.CalcolaMostra);
            // 
            // cbB
            // 
            this.cbB.AutoSize = true;
            this.cbB.BackColor = System.Drawing.Color.Black;
            this.cbB.Checked = true;
            this.cbB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbB.ForeColor = System.Drawing.SystemColors.Control;
            this.cbB.Location = new System.Drawing.Point(310, 7);
            this.cbB.Margin = new System.Windows.Forms.Padding(2);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(33, 17);
            this.cbB.TabIndex = 67;
            this.cbB.Text = "B";
            this.cbB.UseVisualStyleBackColor = false;
            this.cbB.CheckedChanged += new System.EventHandler(this.CalcolaMostra);
            // 
            // cbR
            // 
            this.cbR.AutoSize = true;
            this.cbR.BackColor = System.Drawing.Color.Red;
            this.cbR.Checked = true;
            this.cbR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbR.Location = new System.Drawing.Point(344, 7);
            this.cbR.Margin = new System.Windows.Forms.Padding(2);
            this.cbR.Name = "cbR";
            this.cbR.Size = new System.Drawing.Size(34, 17);
            this.cbR.TabIndex = 68;
            this.cbR.Text = "R";
            this.cbR.UseVisualStyleBackColor = false;
            this.cbR.CheckedChanged += new System.EventHandler(this.CalcolaMostra);
            // 
            // cbG
            // 
            this.cbG.AutoSize = true;
            this.cbG.BackColor = System.Drawing.Color.Green;
            this.cbG.Checked = true;
            this.cbG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbG.ForeColor = System.Drawing.SystemColors.Control;
            this.cbG.Location = new System.Drawing.Point(379, 7);
            this.cbG.Margin = new System.Windows.Forms.Padding(2);
            this.cbG.Name = "cbG";
            this.cbG.Size = new System.Drawing.Size(34, 17);
            this.cbG.TabIndex = 69;
            this.cbG.Text = "G";
            this.cbG.UseVisualStyleBackColor = false;
            this.cbG.CheckedChanged += new System.EventHandler(this.CalcolaMostra);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.BtnDorks);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.cbC);
            this.panel2.Controls.Add(this.cbR);
            this.panel2.Controls.Add(this.lblicoloridentity);
            this.panel2.Controls.Add(this.cbB);
            this.panel2.Controls.Add(this.cbG);
            this.panel2.Controls.Add(this.cbU);
            this.panel2.Controls.Add(this.cbW);
            this.panel2.Location = new System.Drawing.Point(555, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 29);
            this.panel2.TabIndex = 71;
            this.panel2.Visible = false;
            // 
            // BtnDorks
            // 
            this.BtnDorks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDorks.BackgroundImage")));
            this.BtnDorks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDorks.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDorks.Location = new System.Drawing.Point(534, 3);
            this.BtnDorks.Name = "BtnDorks";
            this.BtnDorks.Size = new System.Drawing.Size(84, 23);
            this.BtnDorks.TabIndex = 73;
            this.BtnDorks.Text = "Rocks&&Dorks";
            this.BtnDorks.UseVisualStyleBackColor = true;
            this.BtnDorks.Click += new System.EventHandler(this.BtnDorks_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(453, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 72;
            this.button2.Text = "AutoLand";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.BackColor = System.Drawing.Color.Gray;
            this.cbC.Checked = true;
            this.cbC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbC.ForeColor = System.Drawing.SystemColors.Control;
            this.cbC.Location = new System.Drawing.Point(414, 7);
            this.cbC.Margin = new System.Windows.Forms.Padding(2);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(33, 17);
            this.cbC.TabIndex = 71;
            this.cbC.Text = "C";
            this.cbC.UseVisualStyleBackColor = false;
            this.cbC.CheckedChanged += new System.EventHandler(this.CalcolaMostra);
            // 
            // FLPCharts
            // 
            this.FLPCharts.BackColor = System.Drawing.Color.Maroon;
            this.FLPCharts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FLPCharts.BackgroundImage")));
            this.FLPCharts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FLPCharts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FLPCharts.Controls.Add(this.chart1);
            this.FLPCharts.Controls.Add(this.chart2);
            this.FLPCharts.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.FLPCharts.Location = new System.Drawing.Point(556, 67);
            this.FLPCharts.Margin = new System.Windows.Forms.Padding(2);
            this.FLPCharts.Name = "FLPCharts";
            this.FLPCharts.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.FLPCharts.Size = new System.Drawing.Size(486, 352);
            this.FLPCharts.TabIndex = 1;
            this.FLPCharts.Visible = false;
            this.FLPCharts.Paint += new System.Windows.Forms.PaintEventHandler(this.FLPCharts_Paint);
            this.FLPCharts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FLPCharts_MouseClick);
            this.FLPCharts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FLPCharts_MouseDown);
            this.FLPCharts.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FLPCharts_MouseMove);
            this.FLPCharts.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FLPCharts_MouseUp);
            // 
            // LblTot
            // 
            this.LblTot.AutoSize = true;
            this.LblTot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.LblTot.ForeColor = System.Drawing.SystemColors.Control;
            this.LblTot.Location = new System.Drawing.Point(1233, 13);
            this.LblTot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTot.Name = "LblTot";
            this.LblTot.Size = new System.Drawing.Size(102, 13);
            this.LblTot.TabIndex = 72;
            this.LblTot.Text = "Carte totali taggate: ";
            this.LblTot.Visible = false;
            // 
            // lblTotalTags
            // 
            this.lblTotalTags.AutoSize = true;
            this.lblTotalTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.lblTotalTags.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalTags.Location = new System.Drawing.Point(1339, 13);
            this.lblTotalTags.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalTags.Name = "lblTotalTags";
            this.lblTotalTags.Size = new System.Drawing.Size(13, 13);
            this.lblTotalTags.TabIndex = 73;
            this.lblTotalTags.Text = "0";
            this.lblTotalTags.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1611, 808);
            this.Controls.Add(this.lblTotalTags);
            this.Controls.Add(this.LblTot);
            this.Controls.Add(this.FLPCharts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDarkMode);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.TxtInfo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblprec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.awd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsucc);
            this.Controls.Add(this.txtci);
            this.Controls.Add(this.txtHand);
            this.Controls.Add(this.txtDeck);
            this.Controls.Add(this.Btn_calculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MtgStats";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvDeck_KeyPress);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FlpOpzioniDeck.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.FLPCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_calculate;
        private System.Windows.Forms.TextBox txtDeck;
        private System.Windows.Forms.TextBox txtHand;
        private System.Windows.Forms.TextBox txtsucc;
        private System.Windows.Forms.TextBox txtci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label awd;
        private System.Windows.Forms.Label lblprec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCreaTag;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCopia;
        private System.Windows.Forms.Button btnDarkMode;
        private  System.Windows.Forms.ListView lvDeck;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnClip;
        private System.Windows.Forms.Panel panel1;
        private  System.Windows.Forms.PictureBox pictureBox2;
        private  System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox CbColori;
        private System.Windows.Forms.CheckBox CBSelezioneMultipla;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lblicoloridentity;
        private System.Windows.Forms.CheckBox cbW;
        private System.Windows.Forms.CheckBox cbU;
        private System.Windows.Forms.CheckBox cbB;
        private System.Windows.Forms.CheckBox cbR;
        private System.Windows.Forms.CheckBox cbG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnStampa;
        private System.Windows.Forms.Button BtnMox;
        private System.Windows.Forms.FlowLayoutPanel FlpOpzioniDeck;
        private   System.Windows.Forms.Label lblDeck;
        private System.Windows.Forms.FlowLayoutPanel FLPCharts;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.Label LblTot;
        private  System.Windows.Forms.Label lblTotalTags;
        private System.Windows.Forms.CheckBox cbDrag;
        private   System.Windows.Forms.Label lblTotalTags2;
        private System.Windows.Forms.Button BtnImportaFile;
        private System.Windows.Forms.Button BtnSaveFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnDorks;
        private ResizablePictureBox pictureBox1;
    }
}

