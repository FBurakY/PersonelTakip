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
using System.Configuration;
using System.IO;


namespace Gıdaks
{
    public partial class PersonelEkle : Form
    {
        

        public PersonelEkle()
        {
            InitializeComponent();
        }  
        
        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            //Geri Butonu
            AnaSayfa ana_Sayfa = new AnaSayfa();
            ana_Sayfa.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            ToolTip l1 = new ToolTip();
            l1.SetToolTip(button2, "Personel Listele ");
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ToolTip l2 = new ToolTip();
            l2.SetToolTip(button1, "Personel Kaydet ");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            ToolTip l3 = new ToolTip();
            l3.SetToolTip(button3, "Ana Menü ");
        }

        MySqlConnection log = new MySqlConnection("Server=localhost;Database=gidaks_ptakip_db;Uid=root;password=20162024;Encrypt=true");    
        public void veriler(String veriler)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(veriler,log);
            DataSet ds = new DataSet();
            da.Fill(ds);

            p_EkleView1.DataSource = ds.Tables[0]; 

        }

            
        private void button2_Click(object sender, EventArgs e)
        {                  
            //Personeli Listele            
            veriler("Select *From personel");            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //Personel Ekle 
            try
            {
                if (log.State == ConnectionState.Closed &&
                     pEkle_TexBox_Ad.Text.Trim()!="" && pEkle_TexBox_Soyad.Text.Trim()!=""&&
                       pEkle_TexBox_Adres.Text.Trim()!=""&& pEkle_TexBox_Maas.Text.Trim()!="" && pEkle_TexBox_Telefon.Text.Trim()!="")
                       
                {
                    log.Open();
                    //Bağlantımı kontrol ediyorum eğer kapalıysa açıyorum.
                    String ekle = "insert into personel(ad,soyad,telefon,adres,netMaas,statü) values(@ad,@soyad,@telefon,@adres,@netMaas,@statü)";
                    MySqlCommand komut = new MySqlCommand(ekle, log);
                    //Sorgumuzu ve komutumuzu bir parametre olarak alan bir MysqlCommand nesnesi oluşturuyoruz.
                    komut.Parameters.AddWithValue("@ad", pEkle_TexBox_Ad.Text);
                    komut.Parameters.AddWithValue("@soyad", pEkle_TexBox_Soyad.Text);
                    komut.Parameters.AddWithValue("@telefon", pEkle_TexBox_Telefon.Text);
                    komut.Parameters.AddWithValue("@adres", pEkle_TexBox_Adres.Text);
                    komut.Parameters.AddWithValue("@netMaas", pEkle_TexBox_Maas.Text);
                    komut.Parameters.AddWithValue("@statü", pEkle_ComboBox_Statü.Text);
                    //Parametrelerimize Form üzerinde ki kontrolden gelen verilerimizi aktariyoruz.
                    komut.ExecuteNonQuery();
                    //Veritabanımıza değişiklik yapacak komut burada gerçekleştiriliyor.
                    log.Close();
                    veriler("Select *From personel");
                }
                else
                {
                    MessageBox.Show("Zorunlu Alanları Doldurunuz","Uyarı");
                }
            }catch(Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu."+hata.Message);
            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            ToolTip sil = new ToolTip();
            sil.SetToolTip(button4, "Temizle");
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            //Temizle Butonu 
            //TexBoxların içini temizliyorum
            pEkle_TexBox_Ad.Clear();
            pEkle_TexBox_Soyad.Clear();
            pEkle_TexBox_Telefon.Clear();
            pEkle_TexBox_Adres.Clear();
            pEkle_TexBox_Maas.Clear();
            //ComboBox içini temizliyorum.
            pEkle_ComboBox_Statü.Items.RemoveAt(pEkle_ComboBox_Statü.SelectedIndex);
            
        }
    }
}
