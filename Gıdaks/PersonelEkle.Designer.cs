namespace Gıdaks
{
    partial class PersonelEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pEkle_TexBox_Ad = new System.Windows.Forms.TextBox();
            this.pEkle_TexBox_Soyad = new System.Windows.Forms.TextBox();
            this.pEkle_TexBox_Telefon = new System.Windows.Forms.TextBox();
            this.pEkle_TexBox_Adres = new System.Windows.Forms.TextBox();
            this.pEkle_ComboBox_Statü = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pEkle_TexBox_Maas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.p_EkleView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.p_EkleView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(510, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(513, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Statü : ";
            // 
            // pEkle_TexBox_Ad
            // 
            this.pEkle_TexBox_Ad.BackColor = System.Drawing.Color.SeaShell;
            this.pEkle_TexBox_Ad.Location = new System.Drawing.Point(88, 20);
            this.pEkle_TexBox_Ad.Name = "pEkle_TexBox_Ad";
            this.pEkle_TexBox_Ad.Size = new System.Drawing.Size(157, 20);
            this.pEkle_TexBox_Ad.TabIndex = 5;
            this.pEkle_TexBox_Ad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.pEkle_TexBox_Ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // pEkle_TexBox_Soyad
            // 
            this.pEkle_TexBox_Soyad.Location = new System.Drawing.Point(88, 46);
            this.pEkle_TexBox_Soyad.Name = "pEkle_TexBox_Soyad";
            this.pEkle_TexBox_Soyad.Size = new System.Drawing.Size(157, 20);
            this.pEkle_TexBox_Soyad.TabIndex = 6;
            this.pEkle_TexBox_Soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // pEkle_TexBox_Telefon
            // 
            this.pEkle_TexBox_Telefon.Location = new System.Drawing.Point(88, 72);
            this.pEkle_TexBox_Telefon.Name = "pEkle_TexBox_Telefon";
            this.pEkle_TexBox_Telefon.Size = new System.Drawing.Size(157, 20);
            this.pEkle_TexBox_Telefon.TabIndex = 7;
            this.pEkle_TexBox_Telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // pEkle_TexBox_Adres
            // 
            this.pEkle_TexBox_Adres.Location = new System.Drawing.Point(571, 49);
            this.pEkle_TexBox_Adres.Multiline = true;
            this.pEkle_TexBox_Adres.Name = "pEkle_TexBox_Adres";
            this.pEkle_TexBox_Adres.Size = new System.Drawing.Size(260, 89);
            this.pEkle_TexBox_Adres.TabIndex = 8;
            // 
            // pEkle_ComboBox_Statü
            // 
            this.pEkle_ComboBox_Statü.FormattingEnabled = true;
            this.pEkle_ComboBox_Statü.Items.AddRange(new object[] {
            "Döner Ustası",
            "Mutfak Şef",
            "Garson",
            "Komi",
            "Kasiyer",
            "Kuryer"});
            this.pEkle_ComboBox_Statü.Location = new System.Drawing.Point(571, 23);
            this.pEkle_ComboBox_Statü.Name = "pEkle_ComboBox_Statü";
            this.pEkle_ComboBox_Statü.Size = new System.Drawing.Size(260, 21);
            this.pEkle_ComboBox_Statü.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(33, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 50);
            this.button1.TabIndex = 11;
            this.button1.Tag = "Personel Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(33, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 50);
            this.button2.TabIndex = 12;
            this.button2.Tag = "Personeli Listele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // pEkle_TexBox_Maas
            // 
            this.pEkle_TexBox_Maas.Location = new System.Drawing.Point(88, 98);
            this.pEkle_TexBox_Maas.Name = "pEkle_TexBox_Maas";
            this.pEkle_TexBox_Maas.Size = new System.Drawing.Size(157, 20);
            this.pEkle_TexBox_Maas.TabIndex = 14;
            this.pEkle_TexBox_Maas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(6, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Net Maaş :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(34, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 50);
            this.button3.TabIndex = 15;
            this.button3.Tag = "Ana Menüye Dön";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // p_EkleView1
            // 
            this.p_EkleView1.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.p_EkleView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.p_EkleView1.EnableHeadersVisualStyles = false;
            this.p_EkleView1.GridColor = System.Drawing.Color.DarkOrange;
            this.p_EkleView1.Location = new System.Drawing.Point(89, 144);
            this.p_EkleView1.MultiSelect = false;
            this.p_EkleView1.Name = "p_EkleView1";
            this.p_EkleView1.ReadOnly = true;
            this.p_EkleView1.Size = new System.Drawing.Size(760, 217);
            this.p_EkleView1.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(34, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 50);
            this.button4.TabIndex = 17;
            this.button4.Tag = "Personeli Listele";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(861, 403);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.p_EkleView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pEkle_TexBox_Maas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pEkle_ComboBox_Statü);
            this.Controls.Add(this.pEkle_TexBox_Adres);
            this.Controls.Add(this.pEkle_TexBox_Telefon);
            this.Controls.Add(this.pEkle_TexBox_Soyad);
            this.Controls.Add(this.pEkle_TexBox_Ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gıdak\'s Personel Ekle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_EkleView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pEkle_TexBox_Ad;
        private System.Windows.Forms.TextBox pEkle_TexBox_Soyad;
        private System.Windows.Forms.TextBox pEkle_TexBox_Telefon;
        private System.Windows.Forms.TextBox pEkle_TexBox_Adres;
        private System.Windows.Forms.ComboBox pEkle_ComboBox_Statü;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox pEkle_TexBox_Maas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView p_EkleView1;
        private System.Windows.Forms.Button button4;
    }
}