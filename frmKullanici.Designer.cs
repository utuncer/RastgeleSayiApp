namespace RastgeleSayiToplamApp
{
    partial class frmKullanici
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
            gbKullanici = new GroupBox();
            btnGirisYap = new Button();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            lblSoyad = new Label();
            lblAd = new Label();
            gbKullanici.SuspendLayout();
            SuspendLayout();
            // 
            // gbKullanici
            // 
            gbKullanici.Controls.Add(btnGirisYap);
            gbKullanici.Controls.Add(txtSoyad);
            gbKullanici.Controls.Add(txtAd);
            gbKullanici.Controls.Add(lblSoyad);
            gbKullanici.Controls.Add(lblAd);
            gbKullanici.Location = new Point(12, 12);
            gbKullanici.Name = "gbKullanici";
            gbKullanici.Size = new Size(469, 232);
            gbKullanici.TabIndex = 4;
            gbKullanici.TabStop = false;
            gbKullanici.Text = "Kullanıcı Bilgileri";
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(187, 148);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(94, 29);
            btnGirisYap.TabIndex = 29;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(172, 102);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 28;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(172, 56);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 27;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(116, 104);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(50, 20);
            lblSoyad.TabIndex = 24;
            lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(138, 59);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 25;
            lblAd.Text = "Ad";
            // 
            // frmKullanici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 256);
            Controls.Add(gbKullanici);
            MaximumSize = new Size(511, 303);
            MinimumSize = new Size(511, 303);
            Name = "frmKullanici";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Girişi";
            WindowState = FormWindowState.Minimized;
            gbKullanici.ResumeLayout(false);
            gbKullanici.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbKullanici;
        private Label lblSoyad;
        private Label lblAd;
        private Button btnGirisYap;
        private TextBox txtSoyad;
        private TextBox txtAd;
    }
}