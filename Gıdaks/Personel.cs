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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            veriler("SELECT ad,soyad,telefon,adres,netMaas,statü,izinSayisi,izinTarihi,avans,avansTarihi FROM personel,izin,avans where pID=iID and pID=aID");
        }
        public void veriler(String veriler)
        {
            MySqlConnection log = new MySqlConnection("Server=localhost;Database=gidaks_ptakip_db;Uid=root;password=20162024;Encrypt=true");
            //Veritabanındaki verileri Listeliyoruz
            MySqlDataAdapter da = new MySqlDataAdapter(veriler,log);
            DataSet ds = new DataSet();
            da.Fill(ds);

            bilgiView.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pGuncelle_Ad.Text = pGuncelle_View.Rows[e.RowIndex].Cells[1].Value.ToString();

            adTxt.Text=bilgiView.Rows[e.RowIndex].Cells[0].Value.ToString();
            soyadTxt.Text=bilgiView.Rows[e.RowIndex].Cells[1].Value.ToString();
            telefonTxt.Text=bilgiView.Rows[e.RowIndex].Cells[2].Value.ToString();
            adresTxt.Text=bilgiView.Rows[e.RowIndex].Cells[3].Value.ToString();
            toplammaasTxt.Text=bilgiView.Rows[e.RowIndex].Cells[4].Value.ToString();
            statuComboBox.Text=bilgiView.Rows[e.RowIndex].Cells[5].Value.ToString();
            iGunSayisiTxt.Text=bilgiView.Rows[e.RowIndex].Cells[6].Value.ToString();
            iGunTxt.Text=bilgiView.Rows[e.RowIndex].Cells[7].Value.ToString();
            avansTxt.Text=bilgiView.Rows[e.RowIndex].Cells[8].Value.ToString();
            avansTarihTxt.Text=bilgiView.Rows[e.RowIndex].Cells[9].Value.ToString();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonelBilgiTakip geri = new PersonelBilgiTakip();
            geri.Show();
            this.Hide();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            //Personel Listele
            ToolTip l1 = new ToolTip();
            l1.SetToolTip(button2,"Personel Listele");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            //Ana Menü
            ToolTip l2 = new ToolTip();
            l2.SetToolTip(button4,"Geri");
        }




    }
}
