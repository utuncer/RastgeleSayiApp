using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleSayiToplamApp
{
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var frm = new frmOyun(txtAd.Text.Trim(),txtSoyad.Text.Trim());
            frm.Show();
        }

        //private void btnGirisYap_Click(object sender, EventArgs e)
        //{

        //    if (txtAd.Text.Trim() == "" || txtSoyad.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Kullanıcı Adı veya Soyadı Boş");
        //        return;
        //    }

        //    foreach (char c in txtSoyad.Text.Trim())
        //    {
        //        if (c == ' ')
        //        {
        //            MessageBox.Show($"'{txtSoyad.Text}' -> Soyadınız Boşluk İçeriyor!");
        //            return;
        //        }
        //    }

        //    string Soyad = txtSoyad.Text.Trim();
        //    string Ad = "";

        //    bool sonEklenenBoslukMu = false;


        //    foreach (char c in txtAd.Text.Trim())
        //    {
        //        if (c == ' ')
        //        {
        //            if (!sonEklenenBoslukMu)
        //            {
        //                Ad += ' ';

        //                sonEklenenBoslukMu = true;
        //            }

        //        }
        //        else
        //        {
        //            Ad += c;

        //            sonEklenenBoslukMu = false;
        //        }
        //    }



        //    frmOyun frmoyun = new frmOyun(Ad, Soyad);

        //    this.Hide();
        //    frmoyun.Show();

        //}

        //private void FormBilgileri_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
        //    {
        //        e.Handled = true;
        //    }
        //}

    }
}
