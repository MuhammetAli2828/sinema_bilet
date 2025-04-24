namespace WindowsFormsApp7
{
    partial class kullanicianaform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblkullaniciad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_oyuculiste = new System.Windows.Forms.Button();
            this.btnbiletislem = new System.Windows.Forms.Button();
            this.btnyontmenliste = new System.Windows.Forms.Button();
            this.btntümfilmler = new System.Windows.Forms.Button();
            this.btngelecekfilm = new System.Windows.Forms.Button();
            this.lblbiletim = new System.Windows.Forms.Button();
            this.lblkoltuklar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblkullaniciad);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1942, 59);
            this.panel1.TabIndex = 2;
            this.panel1.UseWaitCursor = true;
            // 
            // lblkullaniciad
            // 
            this.lblkullaniciad.AutoSize = true;
            this.lblkullaniciad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullaniciad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblkullaniciad.Location = new System.Drawing.Point(1794, 9);
            this.lblkullaniciad.Name = "lblkullaniciad";
            this.lblkullaniciad.Size = new System.Drawing.Size(79, 29);
            this.lblkullaniciad.TabIndex = 2;
            this.lblkullaniciad.Text = "label2";
            this.lblkullaniciad.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1899, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "FilmFiesta.com";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_oyuculiste
            // 
            this.btn_oyuculiste.BackColor = System.Drawing.Color.White;
            this.btn_oyuculiste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_oyuculiste.FlatAppearance.BorderSize = 2;
            this.btn_oyuculiste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oyuculiste.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oyuculiste.ForeColor = System.Drawing.Color.Black;
            this.btn_oyuculiste.Location = new System.Drawing.Point(0, 74);
            this.btn_oyuculiste.Name = "btn_oyuculiste";
            this.btn_oyuculiste.Size = new System.Drawing.Size(225, 42);
            this.btn_oyuculiste.TabIndex = 12;
            this.btn_oyuculiste.Text = "Oyuncu Liste Ekranı";
            this.btn_oyuculiste.UseVisualStyleBackColor = false;
            this.btn_oyuculiste.UseWaitCursor = true;
            this.btn_oyuculiste.Click += new System.EventHandler(this.btn_oyuculiste_Click);
            // 
            // btnbiletislem
            // 
            this.btnbiletislem.BackColor = System.Drawing.Color.White;
            this.btnbiletislem.FlatAppearance.BorderSize = 2;
            this.btnbiletislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbiletislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbiletislem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnbiletislem.Location = new System.Drawing.Point(0, 144);
            this.btnbiletislem.Name = "btnbiletislem";
            this.btnbiletislem.Size = new System.Drawing.Size(225, 42);
            this.btnbiletislem.TabIndex = 13;
            this.btnbiletislem.Text = "Bilet İşlemleri";
            this.btnbiletislem.UseVisualStyleBackColor = false;
            this.btnbiletislem.UseWaitCursor = true;
            this.btnbiletislem.Click += new System.EventHandler(this.btnbiletislem_Click);
            // 
            // btnyontmenliste
            // 
            this.btnyontmenliste.BackColor = System.Drawing.Color.White;
            this.btnyontmenliste.FlatAppearance.BorderSize = 2;
            this.btnyontmenliste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyontmenliste.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyontmenliste.ForeColor = System.Drawing.Color.Black;
            this.btnyontmenliste.Location = new System.Drawing.Point(0, 279);
            this.btnyontmenliste.Name = "btnyontmenliste";
            this.btnyontmenliste.Size = new System.Drawing.Size(227, 50);
            this.btnyontmenliste.TabIndex = 14;
            this.btnyontmenliste.Text = "Yönetmenler Listesi";
            this.btnyontmenliste.UseVisualStyleBackColor = false;
            this.btnyontmenliste.UseWaitCursor = true;
            this.btnyontmenliste.Click += new System.EventHandler(this.btnyontmenliste_Click);
            // 
            // btntümfilmler
            // 
            this.btntümfilmler.BackColor = System.Drawing.Color.White;
            this.btntümfilmler.FlatAppearance.BorderSize = 2;
            this.btntümfilmler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntümfilmler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntümfilmler.ForeColor = System.Drawing.Color.Black;
            this.btntümfilmler.Location = new System.Drawing.Point(0, 354);
            this.btntümfilmler.Name = "btntümfilmler";
            this.btntümfilmler.Size = new System.Drawing.Size(227, 42);
            this.btntümfilmler.TabIndex = 15;
            this.btntümfilmler.Text = "Tüm Filmler";
            this.btntümfilmler.UseVisualStyleBackColor = false;
            this.btntümfilmler.UseWaitCursor = true;
            this.btntümfilmler.Click += new System.EventHandler(this.btntümfilmler_Click);
            // 
            // btngelecekfilm
            // 
            this.btngelecekfilm.BackColor = System.Drawing.Color.White;
            this.btngelecekfilm.FlatAppearance.BorderSize = 2;
            this.btngelecekfilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngelecekfilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngelecekfilm.ForeColor = System.Drawing.Color.Black;
            this.btngelecekfilm.Location = new System.Drawing.Point(0, 214);
            this.btngelecekfilm.Name = "btngelecekfilm";
            this.btngelecekfilm.Size = new System.Drawing.Size(222, 42);
            this.btngelecekfilm.TabIndex = 17;
            this.btngelecekfilm.Text = "Gelecek Filmler";
            this.btngelecekfilm.UseVisualStyleBackColor = false;
            this.btngelecekfilm.UseWaitCursor = true;
            this.btngelecekfilm.Click += new System.EventHandler(this.btngelecekfilm_Click);
            // 
            // lblbiletim
            // 
            this.lblbiletim.BackColor = System.Drawing.Color.White;
            this.lblbiletim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblbiletim.FlatAppearance.BorderSize = 2;
            this.lblbiletim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblbiletim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbiletim.ForeColor = System.Drawing.Color.Black;
            this.lblbiletim.Location = new System.Drawing.Point(-3, 423);
            this.lblbiletim.Name = "lblbiletim";
            this.lblbiletim.Size = new System.Drawing.Size(225, 42);
            this.lblbiletim.TabIndex = 18;
            this.lblbiletim.Text = "Biletim\r\n";
            this.lblbiletim.UseVisualStyleBackColor = false;
            this.lblbiletim.UseWaitCursor = true;
            this.lblbiletim.Click += new System.EventHandler(this.lblbiletim_Click);
            // 
            // lblkoltuklar
            // 
            this.lblkoltuklar.BackColor = System.Drawing.Color.White;
            this.lblkoltuklar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblkoltuklar.FlatAppearance.BorderSize = 2;
            this.lblkoltuklar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblkoltuklar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkoltuklar.ForeColor = System.Drawing.Color.Black;
            this.lblkoltuklar.Location = new System.Drawing.Point(0, 487);
            this.lblkoltuklar.Name = "lblkoltuklar";
            this.lblkoltuklar.Size = new System.Drawing.Size(225, 42);
            this.lblkoltuklar.TabIndex = 19;
            this.lblkoltuklar.Text = "Koltuklar";
            this.lblkoltuklar.UseVisualStyleBackColor = false;
            this.lblkoltuklar.UseWaitCursor = true;
            this.lblkoltuklar.Click += new System.EventHandler(this.lblkoltuklar_Click);
            // 
            // kullanicianaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 589);
            this.Controls.Add(this.lblkoltuklar);
            this.Controls.Add(this.lblbiletim);
            this.Controls.Add(this.btngelecekfilm);
            this.Controls.Add(this.btntümfilmler);
            this.Controls.Add(this.btnyontmenliste);
            this.Controls.Add(this.btnbiletislem);
            this.Controls.Add(this.btn_oyuculiste);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kullanicianaform";
            this.Text = "kullanicianaform";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.kullanicianaform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblkullaniciad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_oyuculiste;
        private System.Windows.Forms.Button btnbiletislem;
        private System.Windows.Forms.Button btnyontmenliste;
        private System.Windows.Forms.Button btntümfilmler;
        private System.Windows.Forms.Button btngelecekfilm;
        private System.Windows.Forms.Button lblbiletim;
        private System.Windows.Forms.Button lblkoltuklar;
    }
}