using System;

namespace RastgeleSayiTıolamApp
{
    public partial class Form1 : Form
    {
        private int Numb1Counter = 0;
        private int Numb2Counter = 0;
        private int Numb3Counter = 0;
        private int Toplam = 0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnNumb_1.Enabled = false;
            btnNumb_2.Enabled = false;
            btnNumb_3.Enabled = false;
            btnTemizle.Enabled = false;
            btnToplam.Enabled = false;
        }
        private void ButonlariAktifEt()
        {
            btnNumb_1.Enabled = true;
            btnNumb_2.Enabled = true;
            btnNumb_3.Enabled = true;
            btnTemizle.Enabled = true;
            btnToplam.Enabled = true;
        }
        private void Temizle()
        {
            btnNumb_1.Enabled = false;
            btnNumb_2.Enabled = false;
            btnNumb_3.Enabled = false;
            btnTemizle.Enabled = false;
            btnToplam.Enabled = false;
            btnAtamaYap.Enabled = true;
            btnNumb_1.Text = "0";
            btnNumb_2.Text = "0";
            btnNumb_3.Text = "0";
            Numb1Counter = 0;
            Numb2Counter = 0;
            Numb3Counter = 0;
            Toplam = 0;
            labelNum1.Text = "0";
            labelNum2.Text = "0";
            labelNum3.Text = "0";
        }
        private void CounterSayac(ref int counter, Label label)
        {
            counter++;
            label.Text = Convert.ToString(counter);
        }

        private void btnAtamaYap_Click(object sender, EventArgs e)
        {
            try
            {
                //Numb1 = random.Next(int.Parse(txtBaslangic.Text), int.Parse(txtBitis.Text));
                //Numb2 = random.Next(int.Parse(txtBaslangic.Text), int.Parse(txtBitis.Text));
                //Numb3 = random.Next(int.Parse(txtBaslangic.Text), int.Parse(txtBitis.Text));

                //btnNumb_1.Text = Convert.ToString(Numb1);
                //btnNumb_2.Text = Convert.ToString(Numb2);
                //btnNumb_3.Text = Convert.ToString(Numb3);
                foreach (Control item in this.Controls)
                {
                    if (item is Button && item.Tag != null && item.Tag.ToString() == "rastgeleBtn")
                    {
                        item.Text = Convert.ToString(random.Next(int.Parse(txtBaslangic.Text), int.Parse(txtBitis.Text)));
                    }
                }
                btnAtamaYap.Enabled = false;
                ButonlariAktifEt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam: " + Toplam);
        }

        private void btnNumb_1_Click(object sender, EventArgs e)
        {
            CounterSayac(ref Numb1Counter, labelNum1);
            Toplam += int.Parse(btnNumb_1.Text);
        }

        private void btnNumb_2_Click(object sender, EventArgs e)
        {
            CounterSayac(ref Numb2Counter, labelNum2);
            Toplam += int.Parse(btnNumb_2.Text);
        }

        private void btnNumb_3_Click(object sender, EventArgs e)
        {
            CounterSayac(ref Numb3Counter, labelNum3);
            Toplam += int.Parse(btnNumb_3.Text);
        }
    }
}
