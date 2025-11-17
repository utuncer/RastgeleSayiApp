namespace RastgeleSayiTıolamApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAtamaYap = new Button();
            label1 = new Label();
            label2 = new Label();
            txtBaslangic = new TextBox();
            txtBitis = new TextBox();
            btnNumb_1 = new Button();
            btnNumb_2 = new Button();
            btnNumb_3 = new Button();
            btnTemizle = new Button();
            labelNum1 = new Label();
            labelNum2 = new Label();
            labelNum3 = new Label();
            btnToplam = new Button();
            SuspendLayout();
            // 
            // btnAtamaYap
            // 
            btnAtamaYap.Location = new Point(338, 86);
            btnAtamaYap.Name = "btnAtamaYap";
            btnAtamaYap.Size = new Size(94, 29);
            btnAtamaYap.TabIndex = 2;
            btnAtamaYap.Text = "Atama Yap";
            btnAtamaYap.UseVisualStyleBackColor = true;
            btnAtamaYap.Click += btnAtamaYap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 32);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Başlangıç";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(589, 32);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 2;
            label2.Text = "Bitiş (Dahil Değil)";
            // 
            // txtBaslangic
            // 
            txtBaslangic.Location = new Point(129, 29);
            txtBaslangic.Name = "txtBaslangic";
            txtBaslangic.Size = new Size(125, 27);
            txtBaslangic.TabIndex = 0;
            // 
            // txtBitis
            // 
            txtBitis.Location = new Point(458, 29);
            txtBitis.Name = "txtBitis";
            txtBitis.Size = new Size(125, 27);
            txtBitis.TabIndex = 1;
            // 
            // btnNumb_1
            // 
            btnNumb_1.Location = new Point(338, 194);
            btnNumb_1.Name = "btnNumb_1";
            btnNumb_1.Size = new Size(94, 29);
            btnNumb_1.TabIndex = 3;
            btnNumb_1.Tag = "rastgeleBtn";
            btnNumb_1.Text = "0";
            btnNumb_1.UseVisualStyleBackColor = true;
            btnNumb_1.Click += btnNumb_1_Click;
            // 
            // btnNumb_2
            // 
            btnNumb_2.Location = new Point(338, 229);
            btnNumb_2.Name = "btnNumb_2";
            btnNumb_2.Size = new Size(94, 29);
            btnNumb_2.TabIndex = 4;
            btnNumb_2.Tag = "rastgeleBtn";
            btnNumb_2.Text = "0";
            btnNumb_2.UseVisualStyleBackColor = true;
            btnNumb_2.Click += btnNumb_2_Click;
            // 
            // btnNumb_3
            // 
            btnNumb_3.Location = new Point(338, 264);
            btnNumb_3.Name = "btnNumb_3";
            btnNumb_3.Size = new Size(94, 29);
            btnNumb_3.TabIndex = 5;
            btnNumb_3.Tag = "rastgeleBtn";
            btnNumb_3.Text = "0";
            btnNumb_3.UseVisualStyleBackColor = true;
            btnNumb_3.Click += btnNumb_3_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(338, 299);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(94, 29);
            btnTemizle.TabIndex = 6;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // labelNum1
            // 
            labelNum1.AutoSize = true;
            labelNum1.Location = new Point(438, 198);
            labelNum1.Name = "labelNum1";
            labelNum1.Size = new Size(17, 20);
            labelNum1.TabIndex = 2;
            labelNum1.Text = "0";
            // 
            // labelNum2
            // 
            labelNum2.AutoSize = true;
            labelNum2.Location = new Point(438, 233);
            labelNum2.Name = "labelNum2";
            labelNum2.Size = new Size(17, 20);
            labelNum2.TabIndex = 2;
            labelNum2.Text = "0";
            // 
            // labelNum3
            // 
            labelNum3.AutoSize = true;
            labelNum3.Location = new Point(438, 268);
            labelNum3.Name = "labelNum3";
            labelNum3.Size = new Size(17, 20);
            labelNum3.TabIndex = 2;
            labelNum3.Text = "0";
            // 
            // btnToplam
            // 
            btnToplam.Location = new Point(338, 334);
            btnToplam.Name = "btnToplam";
            btnToplam.Size = new Size(94, 29);
            btnToplam.TabIndex = 7;
            btnToplam.Text = "Toplam";
            btnToplam.UseVisualStyleBackColor = true;
            btnToplam.Click += btnToplam_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnToplam);
            Controls.Add(btnTemizle);
            Controls.Add(btnNumb_3);
            Controls.Add(btnNumb_2);
            Controls.Add(btnNumb_1);
            Controls.Add(txtBitis);
            Controls.Add(txtBaslangic);
            Controls.Add(labelNum3);
            Controls.Add(labelNum2);
            Controls.Add(labelNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAtamaYap);
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rastgele Sayi Topla";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtamaYap;
        private Label label1;
        private Label label2;
        private TextBox txtBaslangic;
        private TextBox txtBitis;
        private Button btnNumb_1;
        private Button btnNumb_2;
        private Button btnNumb_3;
        private Button btnTemizle;
        private Label labelNum1;
        private Label labelNum2;
        private Label labelNum3;
        private Button btnToplam;
    }
}
