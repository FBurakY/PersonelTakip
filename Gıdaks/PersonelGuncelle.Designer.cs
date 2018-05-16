namespace Gıdaks
{
    partial class PersonelGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGuncelle));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pGuncelleComboBox_Statü = new System.Windows.Forms.ComboBox();
            this.pGuncelle_View = new System.Windows.Forms.DataGridView();
            this.pGuncelle_Adres = new System.Windows.Forms.TextBox();
            this.pGuncelle_Telefon = new System.Windows.Forms.TextBox();
            this.pGuncelle_Soyad = new System.Windows.Forms.TextBox();
            this.pGuncelle_Ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pGuncelle_Maas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pID_Parametre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pGuncelle_View)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(29, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 50);
            this.button2.TabIndex = 25;
            this.button2.Tag = "Personel Listele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.CausesValidation = false;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(29, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 50);
            this.button1.TabIndex = 24;
            this.button1.Tag = "Personel Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // pGuncelleComboBox_Statü
            // 
            this.pGuncelleComboBox_Statü.FormattingEnabled = true;
            this.pGuncelleComboBox_Statü.Items.AddRange(new object[] {
            "Döner Ustası",
            "Mutfak Şef",
            "Garson",
            "Komi",
            "Kasiyer",
            "Kuryer"});
            this.pGuncelleComboBox_Statü.Location = new System.Drawing.Point(767, 30);
            this.pGuncelleComboBox_Statü.Name = "pGuncelleComboBox_Statü";
            this.pGuncelleComboBox_Statü.Size = new System.Drawing.Size(263, 21);
            this.pGuncelleComboBox_Statü.TabIndex = 23;
            // 
            // pGuncelle_View
            // 
            this.pGuncelle_View.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.pGuncelle_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pGuncelle_View.GridColor = System.Drawing.Color.DarkOrange;
            this.pGuncelle_View.Location = new System.Drawing.Point(84, 155);
            this.pGuncelle_View.MultiSelect = false;
            this.pGuncelle_View.Name = "pGuncelle_View";
            this.pGuncelle_View.ReadOnly = true;
            this.pGuncelle_View.Size = new System.Drawing.Size(946, 218);
            this.pGuncelle_View.TabIndex = 22;
            this.pGuncelle_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pGuncelle_View_CellClick);
            // 
            // pGuncelle_Adres
            // 
            this.pGuncelle_Adres.Location = new System.Drawing.Point(767, 62);
            this.pGuncelle_Adres.Multiline = true;
            this.pGuncelle_Adres.Name = "pGuncelle_Adres";
            this.pGuncelle_Adres.Size = new System.Drawing.Size(263, 89);
            this.pGuncelle_Adres.TabIndex = 21;
            // 
            // pGuncelle_Telefon
            // 
            this.pGuncelle_Telefon.Location = new System.Drawing.Point(84, 89);
            this.pGuncelle_Telefon.Name = "pGuncelle_Telefon";
            this.pGuncelle_Telefon.Size = new System.Drawing.Size(157, 20);
            this.pGuncelle_Telefon.TabIndex = 20;
            this.pGuncelle_Telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // pGuncelle_Soyad
            // 
            this.pGuncelle_Soyad.Location = new System.Drawing.Point(84, 63);
            this.pGuncelle_Soyad.Name = "pGuncelle_Soyad";
            this.pGuncelle_Soyad.Size = new System.Drawing.Size(157, 20);
            this.pGuncelle_Soyad.TabIndex = 19;
            this.pGuncelle_Soyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.pGuncelle_Soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // pGuncelle_Ad
            // 
            this.pGuncelle_Ad.Location = new System.Drawing.Point(84, 37);
            this.pGuncelle_Ad.Name = "pGuncelle_Ad";
            this.pGuncelle_Ad.Size = new System.Drawing.Size(157, 20);
            this.pGuncelle_Ad.TabIndex = 18;
            this.pGuncelle_Ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(709, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Statü : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(706, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Adres : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Telefon : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyad : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ad :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(29, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 50);
            this.button3.TabIndex = 26;
            this.button3.Tag = "Personel Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // pGuncelle_Maas
            // 
            this.pGuncelle_Maas.Location = new System.Drawing.Point(84, 115);
            this.pGuncelle_Maas.Name = "pGuncelle_Maas";
            this.pGuncelle_Maas.Size = new System.Drawing.Size(157, 20);
            this.pGuncelle_Maas.TabIndex = 28;
            this.pGuncelle_Maas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(2, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Net Maaş :";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(29, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 50);
            this.button4.TabIndex = 29;
            this.button4.Tag = "Ana Sayfaya Dön";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // pID_Parametre
            // 
            this.pID_Parametre.AutoSize = true;
            this.pID_Parametre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pID_Parametre.Location = new System.Drawing.Point(81, 9);
            this.pID_Parametre.Name = "pID_Parametre";
            this.pID_Parametre.Size = new System.Drawing.Size(78, 13);
            this.pID_Parametre.TabIndex = 30;
            this.pID_Parametre.Text = "pID_Parametre";
            // 
            // PersonelGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1042, 387);
            this.Controls.Add(this.pID_Parametre);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pGuncelle_Maas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pGuncelleComboBox_Statü);
            this.Controls.Add(this.pGuncelle_View);
            this.Controls.Add(this.pGuncelle_Adres);
            this.Controls.Add(this.pGuncelle_Telefon);
            this.Controls.Add(this.pGuncelle_Soyad);
            this.Controls.Add(this.pGuncelle_Ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Personel Bilgilerini Güncelle";
            this.Text = "Gıdak\'s Personel Güncelle";
            this.Load += new System.EventHandler(this.PersonelGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pGuncelle_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox pGuncelleComboBox_Statü;
        private System.Windows.Forms.DataGridView pGuncelle_View;
        private System.Windows.Forms.TextBox pGuncelle_Adres;
        private System.Windows.Forms.TextBox pGuncelle_Telefon;
        private System.Windows.Forms.TextBox pGuncelle_Soyad;
        private System.Windows.Forms.TextBox pGuncelle_Ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox pGuncelle_Maas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label pID_Parametre;
    }
}