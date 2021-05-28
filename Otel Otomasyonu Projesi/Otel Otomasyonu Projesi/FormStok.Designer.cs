
namespace Otel_Otomasyonu_Projesi
{
    partial class FormStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStok));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.DTPGelisTarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtFirmaAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUrunFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUrunAdet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBKategori = new System.Windows.Forms.ComboBox();
            this.TxtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RBtnOda = new System.Windows.Forms.RadioButton();
            this.RBtnMutfak = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCikis13 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtUrunAra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnAra = new System.Windows.Forms.Button();
            this.BtnAlanTemizle = new System.Windows.Forms.Button();
            this.BtnUrunSil = new System.Windows.Forms.Button();
            this.BtnUrunGoster = new System.Windows.Forms.Button();
            this.BtnUrunGuncelle = new System.Windows.Forms.Button();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.DGVUrunler = new System.Windows.Forms.DataGridView();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKategoriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GelisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.DTPGelisTarih);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtFirmaAdi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtUrunFiyat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtUrunAdet);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CBKategori);
            this.panel1.Controls.Add(this.TxtUrunAdi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 364);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(258, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(493, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "(Alınan ürünün toplam tutarı girilmelidir!!! Adet Fiyatı girilmemelidir!!)";
            // 
            // DTPGelisTarih
            // 
            this.DTPGelisTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTPGelisTarih.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DTPGelisTarih.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DTPGelisTarih.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DTPGelisTarih.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DTPGelisTarih.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DTPGelisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTPGelisTarih.Location = new System.Drawing.Point(541, 175);
            this.DTPGelisTarih.Name = "DTPGelisTarih";
            this.DTPGelisTarih.Size = new System.Drawing.Size(200, 26);
            this.DTPGelisTarih.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(346, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Geliş Tarihi : ";
            // 
            // TxtFirmaAdi
            // 
            this.TxtFirmaAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TxtFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFirmaAdi.ForeColor = System.Drawing.Color.Blue;
            this.TxtFirmaAdi.Location = new System.Drawing.Point(541, 109);
            this.TxtFirmaAdi.Name = "TxtFirmaAdi";
            this.TxtFirmaAdi.Size = new System.Drawing.Size(100, 29);
            this.TxtFirmaAdi.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(346, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Firma Adı : ";
            // 
            // TxtUrunFiyat
            // 
            this.TxtUrunFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TxtUrunFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUrunFiyat.ForeColor = System.Drawing.Color.Blue;
            this.TxtUrunFiyat.Location = new System.Drawing.Point(152, 312);
            this.TxtUrunFiyat.Name = "TxtUrunFiyat";
            this.TxtUrunFiyat.Size = new System.Drawing.Size(100, 29);
            this.TxtUrunFiyat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(11, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ürün Fiyat : ";
            // 
            // TxtUrunAdet
            // 
            this.TxtUrunAdet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TxtUrunAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUrunAdet.ForeColor = System.Drawing.Color.Blue;
            this.TxtUrunAdet.Location = new System.Drawing.Point(152, 243);
            this.TxtUrunAdet.Name = "TxtUrunAdet";
            this.TxtUrunAdet.Size = new System.Drawing.Size(100, 29);
            this.TxtUrunAdet.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(14, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ürün Adet : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(14, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategori : ";
            // 
            // CBKategori
            // 
            this.CBKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CBKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBKategori.ForeColor = System.Drawing.Color.Blue;
            this.CBKategori.FormattingEnabled = true;
            this.CBKategori.Location = new System.Drawing.Point(152, 180);
            this.CBKategori.Name = "CBKategori";
            this.CBKategori.Size = new System.Drawing.Size(121, 32);
            this.CBKategori.TabIndex = 4;
            // 
            // TxtUrunAdi
            // 
            this.TxtUrunAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TxtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUrunAdi.ForeColor = System.Drawing.Color.Blue;
            this.TxtUrunAdi.Location = new System.Drawing.Point(152, 114);
            this.TxtUrunAdi.Name = "TxtUrunAdi";
            this.TxtUrunAdi.Size = new System.Drawing.Size(100, 29);
            this.TxtUrunAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(14, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Bilgileri";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.RBtnOda);
            this.panel3.Controls.Add(this.RBtnMutfak);
            this.panel3.Location = new System.Drawing.Point(3, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 33);
            this.panel3.TabIndex = 0;
            // 
            // RBtnOda
            // 
            this.RBtnOda.AutoSize = true;
            this.RBtnOda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RBtnOda.ForeColor = System.Drawing.Color.Teal;
            this.RBtnOda.Location = new System.Drawing.Point(374, 3);
            this.RBtnOda.Name = "RBtnOda";
            this.RBtnOda.Size = new System.Drawing.Size(128, 24);
            this.RBtnOda.TabIndex = 2;
            this.RBtnOda.TabStop = true;
            this.RBtnOda.Text = "Oda Ürünleri";
            this.RBtnOda.UseVisualStyleBackColor = true;
            this.RBtnOda.CheckedChanged += new System.EventHandler(this.RBtnOda_CheckedChanged);
            // 
            // RBtnMutfak
            // 
            this.RBtnMutfak.AutoSize = true;
            this.RBtnMutfak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RBtnMutfak.ForeColor = System.Drawing.Color.Teal;
            this.RBtnMutfak.Location = new System.Drawing.Point(97, 3);
            this.RBtnMutfak.Name = "RBtnMutfak";
            this.RBtnMutfak.Size = new System.Drawing.Size(150, 24);
            this.RBtnMutfak.TabIndex = 1;
            this.RBtnMutfak.TabStop = true;
            this.RBtnMutfak.Text = "Mutfak Ürünleri";
            this.RBtnMutfak.UseVisualStyleBackColor = true;
            this.RBtnMutfak.CheckedChanged += new System.EventHandler(this.RBtnMutfak_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.BtnCikis13);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.TxtUrunAra);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.BtnAra);
            this.panel2.Controls.Add(this.BtnAlanTemizle);
            this.panel2.Controls.Add(this.BtnUrunSil);
            this.panel2.Controls.Add(this.BtnUrunGoster);
            this.panel2.Controls.Add(this.BtnUrunGuncelle);
            this.panel2.Controls.Add(this.BtnUrunEkle);
            this.panel2.Location = new System.Drawing.Point(803, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 364);
            this.panel2.TabIndex = 1;
            // 
            // BtnCikis13
            // 
            this.BtnCikis13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCikis13.BackgroundImage")));
            this.BtnCikis13.Location = new System.Drawing.Point(465, 24);
            this.BtnCikis13.Name = "BtnCikis13";
            this.BtnCikis13.Size = new System.Drawing.Size(57, 48);
            this.BtnCikis13.TabIndex = 9;
            this.BtnCikis13.UseVisualStyleBackColor = true;
            this.BtnCikis13.Click += new System.EventHandler(this.BtnCikis13_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(58, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "(Aranacak Ürünün ismini girin )";
            // 
            // TxtUrunAra
            // 
            this.TxtUrunAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TxtUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUrunAra.ForeColor = System.Drawing.Color.Blue;
            this.TxtUrunAra.Location = new System.Drawing.Point(196, 296);
            this.TxtUrunAra.Name = "TxtUrunAra";
            this.TxtUrunAra.Size = new System.Drawing.Size(198, 29);
            this.TxtUrunAra.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(57, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ürün Ara : ";
            // 
            // BtnAra
            // 
            this.BtnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.ForeColor = System.Drawing.Color.Purple;
            this.BtnAra.Location = new System.Drawing.Point(412, 288);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(75, 40);
            this.BtnAra.TabIndex = 5;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = false;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnAlanTemizle
            // 
            this.BtnAlanTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAlanTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAlanTemizle.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BtnAlanTemizle.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlanTemizle.Image")));
            this.BtnAlanTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlanTemizle.Location = new System.Drawing.Point(196, 201);
            this.BtnAlanTemizle.Name = "BtnAlanTemizle";
            this.BtnAlanTemizle.Size = new System.Drawing.Size(165, 59);
            this.BtnAlanTemizle.TabIndex = 4;
            this.BtnAlanTemizle.Text = "Alanları Temizle";
            this.BtnAlanTemizle.UseVisualStyleBackColor = false;
            this.BtnAlanTemizle.Click += new System.EventHandler(this.BtnAlanTemizle_Click);
            // 
            // BtnUrunSil
            // 
            this.BtnUrunSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnUrunSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunSil.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BtnUrunSil.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunSil.Image")));
            this.BtnUrunSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUrunSil.Location = new System.Drawing.Point(269, 119);
            this.BtnUrunSil.Name = "BtnUrunSil";
            this.BtnUrunSil.Size = new System.Drawing.Size(177, 64);
            this.BtnUrunSil.TabIndex = 3;
            this.BtnUrunSil.Text = "Ürünü Sil";
            this.BtnUrunSil.UseVisualStyleBackColor = false;
            this.BtnUrunSil.Click += new System.EventHandler(this.BtnUrunSil_Click);
            // 
            // BtnUrunGoster
            // 
            this.BtnUrunGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnUrunGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunGoster.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BtnUrunGoster.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunGoster.Image")));
            this.BtnUrunGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUrunGoster.Location = new System.Drawing.Point(269, 24);
            this.BtnUrunGoster.Name = "BtnUrunGoster";
            this.BtnUrunGoster.Size = new System.Drawing.Size(177, 60);
            this.BtnUrunGoster.TabIndex = 2;
            this.BtnUrunGoster.Text = "Ürünleri Göster";
            this.BtnUrunGoster.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUrunGoster.UseVisualStyleBackColor = false;
            this.BtnUrunGoster.Click += new System.EventHandler(this.BtnUrunGoster_Click);
            // 
            // BtnUrunGuncelle
            // 
            this.BtnUrunGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnUrunGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunGuncelle.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BtnUrunGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunGuncelle.Image")));
            this.BtnUrunGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUrunGuncelle.Location = new System.Drawing.Point(61, 119);
            this.BtnUrunGuncelle.Name = "BtnUrunGuncelle";
            this.BtnUrunGuncelle.Size = new System.Drawing.Size(178, 64);
            this.BtnUrunGuncelle.TabIndex = 1;
            this.BtnUrunGuncelle.Text = "Ürünü Güncelle";
            this.BtnUrunGuncelle.UseVisualStyleBackColor = false;
            this.BtnUrunGuncelle.Click += new System.EventHandler(this.BtnUrunGuncelle_Click);
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunEkle.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BtnUrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunEkle.Image")));
            this.BtnUrunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUrunEkle.Location = new System.Drawing.Point(61, 24);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(178, 60);
            this.BtnUrunEkle.TabIndex = 0;
            this.BtnUrunEkle.Text = "Ürün Ekle";
            this.BtnUrunEkle.UseVisualStyleBackColor = false;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // DGVUrunler
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DGVUrunler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVUrunler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunId,
            this.UrunAdi,
            this.UrunKategoriAdi,
            this.UrunAdet,
            this.UrunFiyat,
            this.FirmaAdi,
            this.GelisTarih});
            this.DGVUrunler.Location = new System.Drawing.Point(291, 373);
            this.DGVUrunler.Name = "DGVUrunler";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUrunler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DGVUrunler.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVUrunler.Size = new System.Drawing.Size(751, 355);
            this.DGVUrunler.TabIndex = 2;
            this.DGVUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUrunler_CellClick);
            // 
            // UrunId
            // 
            this.UrunId.DataPropertyName = "UrunId";
            this.UrunId.HeaderText = "Ürün Sıra Numarası";
            this.UrunId.Name = "UrunId";
            // 
            // UrunAdi
            // 
            this.UrunAdi.DataPropertyName = "UrunAdi";
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            // 
            // UrunKategoriAdi
            // 
            this.UrunKategoriAdi.DataPropertyName = "UrunKategoriAdi";
            this.UrunKategoriAdi.HeaderText = "Ürün Kategori Adı";
            this.UrunKategoriAdi.Name = "UrunKategoriAdi";
            // 
            // UrunAdet
            // 
            this.UrunAdet.DataPropertyName = "UrunAdet";
            this.UrunAdet.HeaderText = "Ürün Adeti";
            this.UrunAdet.Name = "UrunAdet";
            // 
            // UrunFiyat
            // 
            this.UrunFiyat.DataPropertyName = "UrunFiyat";
            this.UrunFiyat.HeaderText = "Ürün Fiyatı";
            this.UrunFiyat.Name = "UrunFiyat";
            // 
            // FirmaAdi
            // 
            this.FirmaAdi.DataPropertyName = "FirmaAdi";
            this.FirmaAdi.HeaderText = "Ürün Firma Adı";
            this.FirmaAdi.Name = "FirmaAdi";
            // 
            // GelisTarih
            // 
            this.GelisTarih.DataPropertyName = "GelisTarih";
            this.GelisTarih.HeaderText = "Ürün Geliş Tarihi";
            this.GelisTarih.Name = "GelisTarih";
            // 
            // FormStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1340, 749);
            this.Controls.Add(this.DGVUrunler);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormStok";
            this.Text = "Stok";
            this.Load += new System.EventHandler(this.FormStok_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RBtnOda;
        private System.Windows.Forms.RadioButton RBtnMutfak;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DTPGelisTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtFirmaAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUrunFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtUrunAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBKategori;
        private System.Windows.Forms.TextBox TxtUrunAra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Button BtnAlanTemizle;
        private System.Windows.Forms.Button BtnUrunSil;
        private System.Windows.Forms.Button BtnUrunGoster;
        private System.Windows.Forms.Button BtnUrunGuncelle;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.DataGridView DGVUrunler;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKategoriAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GelisTarih;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnCikis13;
    }
}