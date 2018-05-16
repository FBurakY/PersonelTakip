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
using System.IO;

namespace Gıdaks
{
    public partial class PersonelGuncelle : Form
    {
        public PersonelGuncelle()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnaSayfa ana_Sayfa = new AnaSayfa();
            ana_Sayfa.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {   
            //Sadece Harf...
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {   
            //Sadece Harf...
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece Rakam...
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {   
            //Sadece Rakam...
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            ToolTip l1 = new ToolTip();
            l1.SetToolTip(button2, "Personel Listele ");
        }


        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ToolTip l2 = new ToolTip();
            l2.SetToolTip(button1, "Personel Sil");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            ToolTip l3 = new ToolTip();
            l3.SetToolTip(button3, "Personel Kaydet/Güncelle");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            ToolTip l4 = new ToolTip();
            l4.SetToolTip(button4, "Ana Menü");
        }

        MySqlConnection log = new MySqlConnection("Server=localhost;Database=gidaks_ptakip_db;Uid=root;password=20162024;Encrypt=true");    
        private void button1_Click(object sender, EventArgs e)
        {
            //DataGridView Tıklanılan Personeli Silme 
            if(pGuncelle_View.SelectedCells.Count>0)
            {
                int selectedRowIndex = pGuncelle_View.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = pGuncelle_View.Rows[selectedRowIndex];
                pID_Parametre.Text = selectedRow.Cells[0].Value.ToString();
            }

            DialogResult uyari = new DialogResult();
            uyari = MessageBox.Show("Personelini Silmek Istediğinizden Eminmisiniz ? ", "Uyarı", MessageBoxButtons.YesNo);
                if(uyari==DialogResult.Yes)
                {
                    personelSil(Convert.ToInt32(pID_Parametre.Text));
                    veriler("Select *from personel");
                }
                if(uyari==DialogResult.No)
                {
                    MessageBox.Show("Pesonel Silme İşlemi İptal Edildi.");
                }

        }

        public void veriler(String veriler)
        {   
            //Veritabanındaki verileri Listeliyoruz
            MySqlDataAdapter da = new MySqlDataAdapter(veriler, log);
            DataSet ds = new DataSet();
            da.Fill(ds);

            pGuncelle_View.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Personel Listele 
            veriler("Select *from personel");
        }

        private void pGuncelle_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            //pGuncelle Datagridview tıklandığında ilgili verler textbox ve combobox yükleniyor
            pGuncelle_Ad.Text = pGuncelle_View.Rows[e.RowIndex].Cells[1].Value.ToString();
            pGuncelle_Soyad.Text = pGuncelle_View.Rows[e.RowIndex].Cells[2].Value.ToString();
            pGuncelle_Telefon.Text = pGuncelle_View.Rows[e.RowIndex].Cells[3].Value.ToString();
            pGuncelle_Adres.Text = pGuncelle_View.Rows[e.RowIndex].Cells[4].Value.ToString();
            pGuncelle_Maas.Text = pGuncelle_View.Rows[e.RowIndex].Cells[5].Value.ToString();
            pGuncelleComboBox_Statü.Text=pGuncelle_View.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Personel Güncelle

            //Datagridview'de tıkladığım hücrenin pId değerini Alıyorum
            if (pGuncelle_View.SelectedCells.Count > 0)
            {
                int selectedRowIndex = pGuncelle_View.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = pGuncelle_View.Rows[selectedRowIndex];
                pID_Parametre.Text = selectedRow.Cells[0].Value.ToString();
            }
            try
            {
                log.Open();
                MySqlCommand personel_Guncelle;
                using (personel_Guncelle = new MySqlCommand("update personel set ad=@p_ad,soyad=@p_soyad,telefon=@p_telefon,adres=@p_adres,netMaas=@p_netMaas,statü=@p_statü where pID=@pID", log))
                {
                    personel_Guncelle.Parameters.AddWithValue("@p_ad",pGuncelle_Ad.Text);
                    personel_Guncelle.Parameters.AddWithValue("@p_soyad",pGuncelle_Soyad.Text);
                    personel_Guncelle.Parameters.AddWithValue("@p_telefon",pGuncelle_Telefon.Text);
                    personel_Guncelle.Parameters.AddWithValue("@p_adres",pGuncelle_Adres.Text);
                    personel_Guncelle.Parameters.AddWithValue("@p_netMaas",pGuncelle_Maas.Text);
                    personel_Guncelle.Parameters.AddWithValue("@p_statü",pGuncelleComboBox_Statü.Text);
                    personel_Guncelle.Parameters.AddWithValue("@pID",pID_Parametre.Text);                    
                    personel_Guncelle.ExecuteNonQuery();
                }                
                log.Close();
                veriler("select *from personel");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Bir Hata Oluştu." + hata.Message);
            }
            
        }

        public  void personelSil(int pID)
        {
            try
            {
                log.Open();
                MySqlCommand komut ;
                using(komut = new MySqlCommand("delete from personel where pID=@pID",log))
                {
                    komut.Parameters.AddWithValue("pID",pID);
                    komut.ExecuteNonQuery();
                }
                log.Close();
                MessageBox.Show("Personel Silindi");
            }catch(Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu."+hata.Message);
            }
        }
                

    }
}
