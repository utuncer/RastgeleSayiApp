using System;
using System.Windows.Forms;

namespace RastgeleSayiToplamApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnForm3Ac_Click(object sender, EventArgs e)
        {
            var frm3 = new Form3(this);


            frm3.Show();
        }
    }
}