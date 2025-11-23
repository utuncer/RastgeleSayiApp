using System;
using System.Windows.Forms;

namespace RastgeleSayiToplamApp
{
    public partial class Form3 : Form
    {
        Form form2;

        public event EventHandler<string> TitleChanged;

        public Form3(Form2 Form2)
        {
            form2 = Form2;
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

             form2.Text = txtFormDegistir.Text;

        }
    }
}