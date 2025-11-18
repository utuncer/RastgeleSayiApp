namespace RastgeleSayiToplamApp
{
    partial class frmOyun
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
            btnOyun = new Button();
            panelEkran = new Panel();
            lblSoyad = new Label();
            lblAd = new Label();
            lblKonum = new Label();
            labelScore = new Label();
            panelEkran.SuspendLayout();
            SuspendLayout();
            // 
            // btnOyun
            // 
            btnOyun.Location = new Point(326, 118);
            btnOyun.Name = "btnOyun";
            btnOyun.Size = new Size(116, 118);
            btnOyun.TabIndex = 0;
            btnOyun.Text = "Yakala";
            btnOyun.UseVisualStyleBackColor = true;
            btnOyun.MouseMove += btnOyun_MouseMove;
            // 
            // panelEkran
            // 
            panelEkran.BackColor = SystemColors.ActiveCaption;
            panelEkran.Controls.Add(lblSoyad);
            panelEkran.Controls.Add(lblAd);
            panelEkran.Controls.Add(lblKonum);
            panelEkran.Controls.Add(labelScore);
            panelEkran.Location = new Point(597, 0);
            panelEkran.Name = "panelEkran";
            panelEkran.Size = new Size(203, 450);
            panelEkran.TabIndex = 1;
            panelEkran.MouseMove += panelEkran_MouseMove;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(3, 45);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(50, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(3, 9);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 1;
            lblAd.Text = "Ad";
            // 
            // lblKonum
            // 
            lblKonum.AutoSize = true;
            lblKonum.Location = new Point(3, 430);
            lblKonum.Name = "lblKonum";
            lblKonum.Size = new Size(32, 20);
            lblKonum.TabIndex = 0;
            lblKonum.Text = "asd";
            lblKonum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(84, 216);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(46, 20);
            labelScore.TabIndex = 0;
            labelScore.Text = "Score";
            labelScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmOyun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelEkran);
            Controls.Add(btnOyun);
            MinimumSize = new Size(818, 497);
            Name = "frmOyun";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buton Yakalama Oyunu";
            WindowState = FormWindowState.Minimized;
            FormClosed += frmOyun_FormClosed;
            Load += frmOyun_Load;
            SizeChanged += frmOyun_SizeChanged;
            MouseMove += frmOyun_MouseMove;
            panelEkran.ResumeLayout(false);
            panelEkran.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOyun;
        private Panel panelEkran;
        private Label labelScore;
        private Label lblKonum;
        private Label lblSoyad;
        private Label lblAd;
    }
}