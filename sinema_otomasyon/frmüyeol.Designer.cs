namespace WindowsFormsApp7
{
    partial class frmüyeol
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
            this.txtüyekadı = new System.Windows.Forms.TextBox();
            this.txtüyeksifre = new System.Windows.Forms.TextBox();
            this.btnüyekaydet = new System.Windows.Forms.Button();
            this.btnüyeiptal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txteposta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtüyekadı
            // 
            this.txtüyekadı.Location = new System.Drawing.Point(352, 38);
            this.txtüyekadı.Name = "txtüyekadı";
            this.txtüyekadı.Size = new System.Drawing.Size(121, 22);
            this.txtüyekadı.TabIndex = 0;
            // 
            // txtüyeksifre
            // 
            this.txtüyeksifre.Location = new System.Drawing.Point(352, 84);
            this.txtüyeksifre.Name = "txtüyeksifre";
            this.txtüyeksifre.Size = new System.Drawing.Size(121, 22);
            this.txtüyeksifre.TabIndex = 1;
            // 
            // btnüyekaydet
            // 
            this.btnüyekaydet.Location = new System.Drawing.Point(229, 183);
            this.btnüyekaydet.Name = "btnüyekaydet";
            this.btnüyekaydet.Size = new System.Drawing.Size(114, 54);
            this.btnüyekaydet.TabIndex = 3;
            this.btnüyekaydet.Text = "KAYDET";
            this.btnüyekaydet.UseVisualStyleBackColor = true;
            this.btnüyekaydet.Click += new System.EventHandler(this.btnüyekaydet_Click);
            // 
            // btnüyeiptal
            // 
            this.btnüyeiptal.Location = new System.Drawing.Point(370, 183);
            this.btnüyeiptal.Name = "btnüyeiptal";
            this.btnüyeiptal.Size = new System.Drawing.Size(103, 54);
            this.btnüyeiptal.TabIndex = 4;
            this.btnüyeiptal.Text = "İPTAL";
            this.btnüyeiptal.UseVisualStyleBackColor = true;
            this.btnüyeiptal.Click += new System.EventHandler(this.btnüyeiptal_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "KULLANICI ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "SİFRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "EPOSTA";
            // 
            // txteposta
            // 
            this.txteposta.Location = new System.Drawing.Point(352, 132);
            this.txteposta.Name = "txteposta";
            this.txteposta.Size = new System.Drawing.Size(121, 22);
            this.txteposta.TabIndex = 8;
            // 
            // frmüyeol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txteposta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnüyeiptal);
            this.Controls.Add(this.btnüyekaydet);
            this.Controls.Add(this.txtüyeksifre);
            this.Controls.Add(this.txtüyekadı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmüyeol";
            this.Text = "frmüyeol";
            this.Load += new System.EventHandler(this.frmüyeol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtüyekadı;
        private System.Windows.Forms.TextBox txtüyeksifre;
        private System.Windows.Forms.Button btnüyekaydet;
        private System.Windows.Forms.Button btnüyeiptal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txteposta;
    }
}