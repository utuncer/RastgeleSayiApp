namespace RastgeleSayiToplamApp
{
    partial class Form2
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
            btnForm3Ac = new Button();
            SuspendLayout();
            // 
            // btnForm3Ac
            // 
            btnForm3Ac.Location = new Point(266, 214);
            btnForm3Ac.Name = "btnForm3Ac";
            btnForm3Ac.Size = new Size(253, 29);
            btnForm3Ac.TabIndex = 0;
            btnForm3Ac.Text = "Form3Ac";
            btnForm3Ac.UseVisualStyleBackColor = true;
            btnForm3Ac.Click += btnForm3Ac_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForm3Ac);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnForm3Ac;
    }
}