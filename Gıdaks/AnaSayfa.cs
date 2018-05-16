using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gıdaks
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
           
        }

        //MySqlConnection baglanti = new MySqlConnection("Server=<SunucuAdi>;Port=3306;Database=<VeritabaniAdi>;Uid=<Kullanıcı Adı>;Pwd=<Sifre>;Encrypt=false;AllowUserVariables=True;UseCompression=True;");


        private void button1_Click(object sender, EventArgs e)
        {
            PersonelEkle p_Ekle = new PersonelEkle();
            p_Ekle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelGuncelle p_Guncelle = new PersonelGuncelle();
            p_Guncelle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelBilgiTakip bilgi = new PersonelBilgiTakip();
            bilgi.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonelMaas maas = new PersonelMaas();
            maas.Show();
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ToolTip a1 = new ToolTip();
            a1.SetToolTip(button1, "Personel Ekle");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            ToolTip a2 = new ToolTip();
            a2.SetToolTip(button2, "Personel Sil veya Güncelle");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            ToolTip a3 = new ToolTip();
            a3.SetToolTip(button3, "Personel Bilgi Takip ");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            ToolTip a4 = new ToolTip();
            a4.SetToolTip(button4, "Personel Avans & izin Ekle");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip l1 = new ToolTip();
            l1.SetToolTip(pictureBox1,"ODUN ATEŞİNDE HATAY DÖNERİ");
        }
    }
}
