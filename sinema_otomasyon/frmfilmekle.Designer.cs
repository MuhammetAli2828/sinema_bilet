namespace WindowsFormsApp7
{
    partial class frmfilmekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfilmekle));
            this.label1 = new System.Windows.Forms.Label();
            this.txtfilmadi = new System.Windows.Forms.TextBox();
            this.listBoxOYUNCU = new System.Windows.Forms.ListBox();
            this.btnoyuncuara = new System.Windows.Forms.Button();
            this.txtoyuncuID = new System.Windows.Forms.TextBox();
            this.txtyonetmenara = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxYONETMEN = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtvizyontarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnyukleresim = new System.Windows.Forms.Button();
            this.pbresim = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIMBD = new System.Windows.Forms.ComboBox();
            this.btnkydtamamla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            // 
            // txtfilmadi
            // 
            this.txtfilmadi.Location = new System.Drawing.Point(423, 168);
            this.txtfilmadi.Name = "txtfilmadi";
            this.txtfilmadi.Size = new System.Drawing.Size(100, 22);
            this.txtfilmadi.TabIndex = 1;
            // 
            // listBoxOYUNCU
            // 
            this.listBoxOYUNCU.FormattingEnabled = true;
            this.listBoxOYUNCU.ItemHeight = 16;
            this.listBoxOYUNCU.Location = new System.Drawing.Point(14, 178);
            this.listBoxOYUNCU.Name = "listBoxOYUNCU";
            this.listBoxOYUNCU.Size = new System.Drawing.Size(258, 84);
            this.listBoxOYUNCU.TabIndex = 2;
            // 
            // btnoyuncuara
            // 
            this.btnoyuncuara.Location = new System.Drawing.Point(23, 127);
            this.btnoyuncuara.Name = "btnoyuncuara";
            this.btnoyuncuara.Size = new System.Drawing.Size(110, 32);
            this.btnoyuncuara.TabIndex = 4;
            this.btnoyuncuara.Text = "Başrol Ara";
            this.btnoyuncuara.UseVisualStyleBackColor = true;
            this.btnoyuncuara.Click += new System.EventHandler(this.btnoyuncuara_Click);
            // 
            // txtoyuncuID
            // 
            this.txtoyuncuID.Location = new System.Drawing.Point(150, 132);
            this.txtoyuncuID.Name = "txtoyuncuID";
            this.txtoyuncuID.Size = new System.Drawing.Size(100, 22);
            this.txtoyuncuID.TabIndex = 5;
            // 
            // txtyonetmenara
            // 
            this.txtyonetmenara.Location = new System.Drawing.Point(150, 315);
            this.txtyonetmenara.Name = "txtyonetmenara";
            this.txtyonetmenara.Size = new System.Drawing.Size(100, 22);
            this.txtyonetmenara.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "yönetmen ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxYONETMEN
            // 
            this.listBoxYONETMEN.FormattingEnabled = true;
            this.listBoxYONETMEN.ItemHeight = 16;
            this.listBoxYONETMEN.Location = new System.Drawing.Point(12, 363);
            this.listBoxYONETMEN.Name = "listBoxYONETMEN";
            this.listBoxYONETMEN.Size = new System.Drawing.Size(260, 100);
            this.listBoxYONETMEN.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vizyon Tarihi:";
            // 
            // dtvizyontarihi
            // 
            this.dtvizyontarihi.Location = new System.Drawing.Point(423, 234);
            this.dtvizyontarihi.Name = "dtvizyontarihi";
            this.dtvizyontarihi.Size = new System.Drawing.Size(127, 22);
            this.dtvizyontarihi.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnyukleresim);
            this.groupBox2.Controls.Add(this.pbresim);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(572, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 171);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // btnyukleresim
            // 
            this.btnyukleresim.BackColor = System.Drawing.Color.White;
            this.btnyukleresim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnyukleresim.FlatAppearance.BorderSize = 0;
            this.btnyukleresim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnyukleresim.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyukleresim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnyukleresim.Location = new System.Drawing.Point(53, 117);
            this.btnyukleresim.Name = "btnyukleresim";
            this.btnyukleresim.Size = new System.Drawing.Size(116, 34);
            this.btnyukleresim.TabIndex = 8;
            this.btnyukleresim.Text = "YÜKLE";
            this.btnyukleresim.UseVisualStyleBackColor = false;
            this.btnyukleresim.Click += new System.EventHandler(this.btnyukleresim_Click_1);
            // 
            // pbresim
            // 
            this.pbresim.BackColor = System.Drawing.Color.White;
            this.pbresim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbresim.Image = ((System.Drawing.Image)(resources.GetObject("pbresim.Image")));
            this.pbresim.Location = new System.Drawing.Point(26, 26);
            this.pbresim.Name = "pbresim";
            this.pbresim.Size = new System.Drawing.Size(175, 69);
            this.pbresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbresim.TabIndex = 7;
            this.pbresim.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(49, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "RESİM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "IMDB Puanı:";
            // 
            // cmbIMBD
            // 
            this.cmbIMBD.FormattingEnabled = true;
            this.cmbIMBD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbIMBD.Location = new System.Drawing.Point(423, 321);
            this.cmbIMBD.Name = "cmbIMBD";
            this.cmbIMBD.Size = new System.Drawing.Size(121, 24);
            this.cmbIMBD.TabIndex = 17;
            // 
            // btnkydtamamla
            // 
            this.btnkydtamamla.BackColor = System.Drawing.Color.Black;
            this.btnkydtamamla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkydtamamla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnkydtamamla.FlatAppearance.BorderSize = 0;
            this.btnkydtamamla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkydtamamla.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkydtamamla.ForeColor = System.Drawing.Color.White;
            this.btnkydtamamla.Location = new System.Drawing.Point(0, 488);
            this.btnkydtamamla.Name = "btnkydtamamla";
            this.btnkydtamamla.Size = new System.Drawing.Size(822, 35);
            this.btnkydtamamla.TabIndex = 19;
            this.btnkydtamamla.Text = "KAYDI TAMAMLA";
            this.btnkydtamamla.UseVisualStyleBackColor = false;
            this.btnkydtamamla.Click += new System.EventHandler(this.btnkydtamamla_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 48);
            this.panel1.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(773, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1370, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 48);
            this.button3.TabIndex = 1;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiilm Ekle";
            // 
            // frmfilmekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnkydtamamla);
            this.Controls.Add(this.cmbIMBD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtvizyontarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtyonetmenara);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxYONETMEN);
            this.Controls.Add(this.txtoyuncuID);
            this.Controls.Add(this.btnoyuncuara);
            this.Controls.Add(this.listBoxOYUNCU);
            this.Controls.Add(this.txtfilmadi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmfilmekle";
            this.Text = "fil";
            this.Load += new System.EventHandler(this.frmfilmekle_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfilmadi;
        private System.Windows.Forms.ListBox listBoxOYUNCU;
        private System.Windows.Forms.Button btnoyuncuara;
        private System.Windows.Forms.TextBox txtoyuncuID;
        private System.Windows.Forms.TextBox txtyonetmenara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxYONETMEN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtvizyontarihi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnyukleresim;
        private System.Windows.Forms.PictureBox pbresim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbIMBD;
        private System.Windows.Forms.Button btnkydtamamla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}