namespace WindowsFormsApp7
{
    partial class OyuncuSıralama
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuSıralama));
            this.pbrsmdetay = new System.Windows.Forms.PictureBox();
            this.lblid = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.btndetay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbrsmdetay)).BeginInit();
            this.SuspendLayout();
            // 
            // pbrsmdetay
            // 
            this.pbrsmdetay.BackColor = System.Drawing.Color.Transparent;
            this.pbrsmdetay.Image = ((System.Drawing.Image)(resources.GetObject("pbrsmdetay.Image")));
            this.pbrsmdetay.Location = new System.Drawing.Point(3, 3);
            this.pbrsmdetay.Name = "pbrsmdetay";
            this.pbrsmdetay.Size = new System.Drawing.Size(113, 68);
            this.pbrsmdetay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbrsmdetay.TabIndex = 3;
            this.pbrsmdetay.TabStop = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Location = new System.Drawing.Point(122, 25);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(59, 23);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "label1";
            this.lblid.Click += new System.EventHandler(this.lblid_Click);
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdSoyad.Location = new System.Drawing.Point(260, 25);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(83, 23);
            this.LblAdSoyad.TabIndex = 4;
            this.LblAdSoyad.Text = "Ad Soyad";
            this.LblAdSoyad.Click += new System.EventHandler(this.LblAdSoyad_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Maroon;
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(645, 19);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 34);
            this.btnsil.TabIndex = 12;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btndetay
            // 
            this.btndetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndetay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndetay.FlatAppearance.BorderSize = 0;
            this.btndetay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndetay.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndetay.ForeColor = System.Drawing.Color.White;
            this.btndetay.Location = new System.Drawing.Point(503, 19);
            this.btndetay.Name = "btndetay";
            this.btndetay.Size = new System.Drawing.Size(136, 34);
            this.btndetay.TabIndex = 11;
            this.btndetay.Text = "DETAY";
            this.btndetay.UseVisualStyleBackColor = false;
            this.btndetay.Click += new System.EventHandler(this.btndetay_Click);
            // 
            // OyuncuSıralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btndetay);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.LblAdSoyad);
            this.Controls.Add(this.pbrsmdetay);
            this.Name = "OyuncuSıralama";
            this.Size = new System.Drawing.Size(723, 71);
            ((System.ComponentModel.ISupportInitialize)(this.pbrsmdetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbrsmdetay;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.Label LblAdSoyad;
        public System.Windows.Forms.Button btnsil;
        public System.Windows.Forms.Button btndetay;
    }
}
