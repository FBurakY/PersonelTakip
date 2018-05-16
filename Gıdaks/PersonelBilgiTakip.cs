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
    public partial class PersonelBilgiTakip : Form
    {
        public PersonelBilgiTakip()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnaSayfa geri = new AnaSayfa();
            geri.Show();
            this.Hide();
        }
        MySqlConnection log = new MySqlConnection("Server=localhost;Database=gidaks_ptakip_db;Uid=root;password=20162024;Encrypt=true");
        public void veriler(String veriler)
        {
            //Veritabanındaki verileri Listeliyoruz
            MySqlDataAdapter da = new MySqlDataAdapter(veriler, log);
            DataSet ds = new DataSet();
            da.Fill(ds);

            bilgiView.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {         
                  
            if(izinRadio.Checked)
            {   //Personel izin Bilgisi
                veriler("SELECT pID,ad,soyad,telefon,izinSayisi,izinTarihi FROM personel,izin where pID=iID");
            }
            if(avansRadio.Checked)
            {   //Personel Avans Bilgisi
                veriler("SELECT pID,ad,soyad,telefon,avans,avansTarihi FROM personel,avans where pID=aID");
            }
            if(gAvansRadio.Checked)
            {
                veriler("SELECT  SUM(gunAvans) FROM gunlukavans where ((personel_pID='" + pID.Text + "') and ( gunlukAvansTarihi>='" + dateTimePicker1.Value + "' and gunlukAvansTarihi<='" + dateTimePicker2.Value + "' ))");
                
            }
             
            if(bilgiRadio.Checked)
            {
                veriler("SELECT * FROM personel");
            }

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            ToolTip l1 = new ToolTip();
            l1.SetToolTip(button2,"Personel Bilgisini Listele Lütfen Seçim Yapınız.");
                
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            ToolTip l1 = new ToolTip();
            l1.SetToolTip(button4, "Ana Menü");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ToolTip l1 = new ToolTip();
            l1.SetToolTip(button2, "Yazır");
        }

        private void bilgiView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Personel bilgi = new Personel();
            bilgi.Show();
            this.Hide();
        }

        private void bilgiView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bilgiView.SelectedCells.Count > 0 && bilgiRadio.Checked==true)
            {
                int selectedRowIndex = bilgiView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = bilgiView.Rows[selectedRowIndex];
                pID.Text = selectedRow.Cells[0].Value.ToString();
                adTxt.Text = bilgiView.Rows[e.RowIndex].Cells[1].Value.ToString();
                soyadTxt.Text = bilgiView.Rows[e.RowIndex].Cells[2].Value.ToString();
                netMaasTxt.Text=bilgiView.Rows[e.RowIndex].Cells[5].Value.ToString();
            }            
            
         }

        private void PersonelBilgiTakip_Load(object sender, EventArgs e)
        {
            veriler("SELECT * FROM personel");
            bilgiRadio.Checked = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
