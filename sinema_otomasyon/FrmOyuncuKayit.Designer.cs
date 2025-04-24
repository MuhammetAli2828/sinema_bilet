namespace WindowsFormsApp7
{
    partial class FrmOyuncuKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOyuncuKayit));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnyukleresim = new System.Windows.Forms.Button();
            this.pbresim = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rberkek = new System.Windows.Forms.RadioButton();
            this.rbkadin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.numyil = new System.Windows.Forms.NumericUpDown();
            this.numay = new System.Windows.Forms.NumericUpDown();
            this.numgun = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblkarakter = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbiyografi = new System.Windows.Forms.TextBox();
            this.btnkydtamamla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numyil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numgun)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnyukleresim);
            this.groupBox2.Controls.Add(this.pbresim);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(24, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 297);
            this.groupBox2.TabIndex = 14;
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
            this.btnyukleresim.Location = new System.Drawing.Point(32, 243);
            this.btnyukleresim.Name = "btnyukleresim";
            this.btnyukleresim.Size = new System.Drawing.Size(256, 34);
            this.btnyukleresim.TabIndex = 8;
            this.btnyukleresim.Text = "YÜKLE";
            this.btnyukleresim.UseVisualStyleBackColor = false;
            this.btnyukleresim.Click += new System.EventHandler(this.btnyukleresim_Click);
            // 
            // pbresim
            // 
            this.pbresim.BackColor = System.Drawing.Color.White;
            this.pbresim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbresim.Image = ((System.Drawing.Image)(resources.GetObject("pbresim.Image")));
            this.pbresim.Location = new System.Drawing.Point(32, 33);
            this.pbresim.Name = "pbresim";
            this.pbresim.Size = new System.Drawing.Size(256, 195);
            this.pbresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbresim.TabIndex = 7;
            this.pbresim.TabStop = false;
            this.pbresim.Click += new System.EventHandler(this.pbresim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "RESİM";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rberkek);
            this.groupBox1.Controls.Add(this.rbkadin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numyil);
            this.groupBox1.Controls.Add(this.numay);
            this.groupBox1.Controls.Add(this.numgun);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(439, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 297);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rberkek
            // 
            this.rberkek.AutoSize = true;
            this.rberkek.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rberkek.ForeColor = System.Drawing.Color.Black;
            this.rberkek.Location = new System.Drawing.Point(164, 234);
            this.rberkek.Name = "rberkek";
            this.rberkek.Size = new System.Drawing.Size(73, 27);
            this.rberkek.TabIndex = 16;
            this.rberkek.Text = "Erkek";
            this.rberkek.UseVisualStyleBackColor = true;
            this.rberkek.CheckedChanged += new System.EventHandler(this.rberkek_CheckedChanged);
            // 
            // rbkadin
            // 
            this.rbkadin.AutoSize = true;
            this.rbkadin.Checked = true;
            this.rbkadin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbkadin.ForeColor = System.Drawing.Color.Black;
            this.rbkadin.Location = new System.Drawing.Point(12, 234);
            this.rbkadin.Name = "rbkadin";
            this.rbkadin.Size = new System.Drawing.Size(74, 27);
            this.rbkadin.TabIndex = 15;
            this.rbkadin.TabStop = true;
            this.rbkadin.Text = "Kadın";
            this.rbkadin.UseVisualStyleBackColor = true;
            this.rbkadin.CheckedChanged += new System.EventHandler(this.rbkadin_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "CİNSİYET";
            // 
            // numyil
            // 
            this.numyil.Location = new System.Drawing.Point(232, 158);
            this.numyil.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numyil.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numyil.Name = "numyil";
            this.numyil.Size = new System.Drawing.Size(79, 34);
            this.numyil.TabIndex = 13;
            this.numyil.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // numay
            // 
            this.numay.Location = new System.Drawing.Point(124, 158);
            this.numay.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numay.Name = "numay";
            this.numay.Size = new System.Drawing.Size(80, 34);
            this.numay.TabIndex = 12;
            this.numay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numgun
            // 
            this.numgun.Location = new System.Drawing.Point(12, 158);
            this.numgun.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numgun.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numgun.Name = "numgun";
            this.numgun.Size = new System.Drawing.Size(79, 34);
            this.numgun.TabIndex = 11;
            this.numgun.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "DOĞUM TARİHİ";
            // 
            // txtsoyad
            // 
            this.txtsoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Location = new System.Drawing.Point(12, 99);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(299, 30);
            this.txtsoyad.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "SOYAD";
            // 
            // txtad
            // 
            this.txtad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtad.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(10, 40);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(301, 30);
            this.txtad.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "AD";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gray;
            this.groupBox3.Controls.Add(this.lblkarakter);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtbiyografi);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(24, 390);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(734, 155);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // lblkarakter
            // 
            this.lblkarakter.AutoSize = true;
            this.lblkarakter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblkarakter.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkarakter.ForeColor = System.Drawing.Color.White;
            this.lblkarakter.Location = new System.Drawing.Point(560, 133);
            this.lblkarakter.Name = "lblkarakter";
            this.lblkarakter.Size = new System.Drawing.Size(163, 19);
            this.lblkarakter.TabIndex = 7;
            this.lblkarakter.Text = "(maximum 300 karakter)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "BİYOGRAFİ";
            // 
            // txtbiyografi
            // 
            this.txtbiyografi.BackColor = System.Drawing.Color.Gray;
            this.txtbiyografi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbiyografi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbiyografi.Location = new System.Drawing.Point(0, 26);
            this.txtbiyografi.MaxLength = 300;
            this.txtbiyografi.Multiline = true;
            this.txtbiyografi.Name = "txtbiyografi";
            this.txtbiyografi.Size = new System.Drawing.Size(933, 139);
            this.txtbiyografi.TabIndex = 8;
            this.txtbiyografi.TextChanged += new System.EventHandler(this.txtbiyografi_TextChanged);
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
            this.btnkydtamamla.Location = new System.Drawing.Point(0, 551);
            this.btnkydtamamla.Name = "btnkydtamamla";
            this.btnkydtamamla.Size = new System.Drawing.Size(798, 34);
            this.btnkydtamamla.TabIndex = 18;
            this.btnkydtamamla.Text = "KAYDI TAMAMLA";
            this.btnkydtamamla.UseVisualStyleBackColor = false;
            this.btnkydtamamla.Click += new System.EventHandler(this.btnkydtamamla_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 48);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(749, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1370, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oyuncu Kayıt Ekranı";
            // 
            // FrmOyuncuKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnkydtamamla);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOyuncuKayit";
            this.Text = "FrmOyuncuKayit";
            this.Load += new System.EventHandler(this.FrmOyuncuKayit_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numyil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numgun)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnyukleresim;
        private System.Windows.Forms.PictureBox pbresim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rberkek;
        private System.Windows.Forms.RadioButton rbkadin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numyil;
        private System.Windows.Forms.NumericUpDown numay;
        private System.Windows.Forms.NumericUpDown numgun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblkarakter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnkydtamamla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbiyografi;
    }
}