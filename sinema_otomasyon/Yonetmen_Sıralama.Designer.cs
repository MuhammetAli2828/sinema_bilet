namespace WindowsFormsApp7
{
    partial class Yonetmen_Sıralama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetmen_Sıralama));
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.pbrsmdetay = new System.Windows.Forms.PictureBox();
            this.btndetay = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbrsmdetay)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdSoyad.Location = new System.Drawing.Point(271, 24);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(83, 23);
            this.LblAdSoyad.TabIndex = 0;
            this.LblAdSoyad.Text = "Ad Soyad";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Location = new System.Drawing.Point(121, 24);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(59, 23);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "label1";
            // 
            // pbrsmdetay
            // 
            this.pbrsmdetay.BackColor = System.Drawing.Color.Transparent;
            this.pbrsmdetay.Image = ((System.Drawing.Image)(resources.GetObject("pbrsmdetay.Image")));
            this.pbrsmdetay.Location = new System.Drawing.Point(2, 0);
            this.pbrsmdetay.Name = "pbrsmdetay";
            this.pbrsmdetay.Size = new System.Drawing.Size(99, 71);
            this.pbrsmdetay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbrsmdetay.TabIndex = 2;
            this.pbrsmdetay.TabStop = false;
            this.pbrsmdetay.Click += new System.EventHandler(this.pbrsmdetay_Click);
            // 
            // btndetay
            // 
            this.btndetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndetay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndetay.FlatAppearance.BorderSize = 0;
            this.btndetay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndetay.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndetay.ForeColor = System.Drawing.Color.White;
            this.btndetay.Location = new System.Drawing.Point(495, 18);
            this.btndetay.Name = "btndetay";
            this.btndetay.Size = new System.Drawing.Size(136, 34);
            this.btndetay.TabIndex = 9;
            this.btndetay.Text = "DETAY";
            this.btndetay.UseVisualStyleBackColor = false;
            this.btndetay.Click += new System.EventHandler(this.btndetay_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Maroon;
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(637, 18);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 34);
            this.btnsil.TabIndex = 10;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // Yonetmen_Sıralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btndetay);
            this.Controls.Add(this.pbrsmdetay);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.LblAdSoyad);
            this.Name = "Yonetmen_Sıralama";
            this.Size = new System.Drawing.Size(723, 71);
            this.Load += new System.EventHandler(this.Yonetmen_Sıralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbrsmdetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblAdSoyad;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.PictureBox pbrsmdetay;
        public System.Windows.Forms.Button btndetay;
        public System.Windows.Forms.Button btnsil;
    }
}
