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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            lblAd = new Label();
            lblSoyad = new Label();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(41, 41);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 0;
            txtAd.KeyPress += FormBilgileri_KeyPress;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(272, 41);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 1;
            txtSoyad.KeyPress += FormBilgileri_KeyPress;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(172, 44);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 2;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(403, 44);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(50, 20);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad";
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(188, 100);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(94, 29);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // frmKullanici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 152);
            Controls.Add(btnGirisYap);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            MinimumSize = new Size(511, 199);
            Name = "frmKullanici";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Girişi";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label lblAd;
        private Label lblSoyad;
        private Button btnGirisYap;
    }
}