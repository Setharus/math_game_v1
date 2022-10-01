using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s1, s2, sonuc, tahmin, toplaDogru = 0, toplaYanlis = 0, cikarDogru = 0, cikarYanlis = 0, carpDogru = 0, carpYanlis = 0, bolDogru = 0, bolYanlis = 0;

        void RastgeleSayiUret() // Değer döndürmeyen ve parametre
            // almayan metod
        {
            Random rastgeleSayi = new Random();
            s1 = rastgeleSayi.Next(1, 100);
            s2 = rastgeleSayi.Next(1, 100);
        }
     
        void sayiYaz(string islem) // değer döndürmeyen ve parametre
            // alan metod
        {
            if (islem == "+")
            {
                txtToplaSay1.Text = s1.ToString();
                txtToplaSay2.Text = s2.ToString();
            }
            else if(islem == "-")
            {
                txtCikarSay1.Text = s1.ToString();
                txtCikarSay2.Text = s2.ToString();
            }
            else if(islem == "*")
            {
                txtCarpSay1.Text = s1.ToString();
                txtCarpSay2.Text = s2.ToString();
            }
            else if(islem == "/")
            {
                txtBolSay1.Text = s1.ToString();
                txtBolSay2.Text = s2.ToString();
            }
        }

        int hesapla(string islem) // değer döndüren parametreli metod
        {
            switch (islem)
            {
                case "+":
                    sonuc = s1 + s2;
                    break;
                case "-":
                    sonuc = s1 - s2;
                    break;
                case "*":
                    sonuc = s1 * s2;
                    break;
                case "/":
                    sonuc = s1 / s2;
                    break;
            }
            return sonuc;
        }

        void temizle()
        {
            txtToplaSonuc.Clear();
            txtCikarSonuc.Clear();
            txtCarpSonuc.Clear();
            txtBolSonuc.Clear();
        }

        private void btnToplaSor_Click(object sender, EventArgs e)
        {
            RastgeleSayiUret();
            sayiYaz("+");
        }

        private void btnToplaKontrolEt_Click(object sender, EventArgs e)
        {
            tahmin = Convert.ToInt32(txtToplaSonuc.Text);
            if(tahmin == hesapla("+"))
            {
                toplaDogru++;
                lblToplaDogru.Text = toplaDogru.ToString();
            }
            else
            {
                toplaYanlis++;
                lblToplaYanlis.Text = toplaYanlis.ToString();
            }
            temizle();
        }

        private void btnCikarSor_Click(object sender, EventArgs e)
        {
            RastgeleSayiUret();
            sayiYaz("-");
        }

        private void btnCikarKontrolEt_Click(object sender, EventArgs e)
        {
            tahmin = Convert.ToInt32(txtCikarSonuc.Text);
            if (tahmin == hesapla("-"))
            {
                cikarDogru++;
                lblCikarDogru.Text = cikarDogru.ToString();
            }
            else
            {
                cikarYanlis++;
                lblCikarYanlis.Text = cikarYanlis.ToString();
            }
            temizle();
        }

        private void btnCarpSor_Click(object sender, EventArgs e)
        {
            RastgeleSayiUret();
            sayiYaz("*");
        }

        private void btnCarpKontrolEt_Click(object sender, EventArgs e)
        {
            tahmin = Convert.ToInt32(txtCarpSonuc.Text);
            if (tahmin == hesapla("*"))
            {
                carpDogru++;
                lblCarpDogru.Text = carpDogru.ToString();
            }
            else
            {
                carpYanlis++;
                lblCarpYanlis.Text = carpYanlis.ToString();
            }
            temizle();
        }

        private void btnBolSor_Click(object sender, EventArgs e)
        {
            RastgeleSayiUret();
            sayiYaz("/");
        }

        private void btnBolKontrolEt_Click(object sender, EventArgs e)
        {
            tahmin = Convert.ToInt32(txtBolSonuc.Text);
            if (tahmin == hesapla("/"))
            {
                bolDogru++;
                lblBolDogru.Text = bolDogru.ToString();
            }
            else
            {
                bolYanlis++;
                lblBolYanlis.Text = bolYanlis.ToString();
            }
            temizle();
        }
    }
}