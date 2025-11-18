namespace RastgeleSayiToplamApp
{
    partial class Form3
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
            txtFormDegistir = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtFormDegistir
            // 
            txtFormDegistir.Location = new Point(316, 156);
            txtFormDegistir.Name = "txtFormDegistir";
            txtFormDegistir.Size = new Size(234, 27);
            txtFormDegistir.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(237, 216);
            button1.Name = "button1";
            button1.Size = new Size(388, 29);
            button1.TabIndex = 1;
            button1.Text = "Form2nin textini değiştir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtFormDegistir);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFormDegistir;
        private Button button1;
    }
}