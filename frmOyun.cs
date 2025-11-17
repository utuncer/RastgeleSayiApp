using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleSayiToplamApp
{
    public partial class frmOyun : Form
    {
        int konumX = 0;
        int konumY = 0;
        int SinirX = 0;
        int SinirY = 0;
        int hataPayi = 0;
        int Score = 0;
        string kullaniciAd;
        string kullaniciSoyad;
        Random random = new Random();

        public frmOyun(string KullaniciAd, string KullaniciSoyad)
        {
            kullaniciAd = KullaniciAd.ToUpper();
            kullaniciSoyad = KullaniciSoyad.ToUpper();
            InitializeComponent();
        }

        private void frmOyun_Load(object sender, EventArgs e)
        {
            lblAd.Text = kullaniciAd;
            lblSoyad.Text = kullaniciSoyad;
            scoreGuncelle(btnOyun);
            scoreGuncelle(labelScore);
        }

        private void scoreGuncelle(Button buton)
        {
            buton.Text = $"Yakala \n {Score}";
        }
        private void scoreGuncelle(Label label)
        {
            label.Text = $"Score \n {Score}";
        }

        private void btnOyun_MouseMove(object sender, MouseEventArgs e)
        {
            Score++;
            scoreGuncelle(btnOyun);
            scoreGuncelle(labelScore);
            RastgeleKonum(btnOyun);
        }

        private void RastgeleKonum(Button buton)
        {
            SinirX = this.ClientSize.Width - buton.Width - panelEkran.Width;
            SinirY = this.ClientSize.Height - buton.Height;
            konumX = random.Next(buton.Width + hataPayi, SinirX - hataPayi);
            konumY = random.Next(buton.Height + hataPayi, SinirY - hataPayi);
            buton.Location = new Point(konumX, konumY);
        }

        private void frmOyun_SizeChanged(object sender, EventArgs e)
        {
            panelEkran.Height = this.ClientSize.Height;
            panelEkran.Location = new Point(this.ClientSize.Width - panelEkran.Width, 0);
        }

        private void frmOyun_MouseMove(object sender, MouseEventArgs e)
        {
            lblKonum.Text = $"X: {e.X}, Y: {e.Y}";

        }

        private void panelEkran_MouseMove(object sender, MouseEventArgs e)
        {
            lblKonum.Text = $"X: {e.X}, Y: {e.Y}";

        }


        private void frmOyun_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblKonum_Click(object sender, EventArgs e)
        {

        }
    }
}
