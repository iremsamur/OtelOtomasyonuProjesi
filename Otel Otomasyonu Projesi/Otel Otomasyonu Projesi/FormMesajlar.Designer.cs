
namespace Otel_Otomasyonu_Projesi
{
    partial class FormMesajlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMesajlar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAlanTemizle3 = new System.Windows.Forms.Button();
            this.BtnMesajSil = new System.Windows.Forms.Button();
            this.BtnMesajGuncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.RTBMesaj = new System.Windows.Forms.RichTextBox();
            this.listViewMesajlar = new System.Windows.Forms.ListView();
            this.MesajId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MusteriAdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MesajIcerik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnCikis5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Ad - Soyad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(125, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesaj : ";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdSoyad.ForeColor = System.Drawing.Color.Blue;
            this.TxtAdSoyad.Location = new System.Drawing.Point(223, 32);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(402, 29);
            this.TxtAdSoyad.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnAlanTemizle3);
            this.panel1.Controls.Add(this.BtnMesajSil);
            this.panel1.Controls.Add(this.BtnMesajGuncelle);
            this.panel1.Controls.Add(this.BtnKaydet);
            this.panel1.Controls.Add(this.RTBMesaj);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtAdSoyad);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 414);
            this.panel1.TabIndex = 3;
            // 
            // BtnAlanTemizle3
            // 
            this.BtnAlanTemizle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnAlanTemizle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAlanTemizle3.ForeColor = System.Drawing.Color.Teal;
            this.BtnAlanTemizle3.Location = new System.Drawing.Point(552, 340);
            this.BtnAlanTemizle3.Name = "BtnAlanTemizle3";
            this.BtnAlanTemizle3.Size = new System.Drawing.Size(149, 64);
            this.BtnAlanTemizle3.TabIndex = 7;
            this.BtnAlanTemizle3.Text = "Alanları Temizle";
            this.BtnAlanTemizle3.UseVisualStyleBackColor = false;
            this.BtnAlanTemizle3.Click += new System.EventHandler(this.BtnAlanTemizle3_Click);
            // 
            // BtnMesajSil
            // 
            this.BtnMesajSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnMesajSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMesajSil.ForeColor = System.Drawing.Color.Teal;
            this.BtnMesajSil.Location = new System.Drawing.Point(373, 340);
            this.BtnMesajSil.Name = "BtnMesajSil";
            this.BtnMesajSil.Size = new System.Drawing.Size(149, 64);
            this.BtnMesajSil.TabIndex = 6;
            this.BtnMesajSil.Text = "Sil";
            this.BtnMesajSil.UseVisualStyleBackColor = false;
            this.BtnMesajSil.Click += new System.EventHandler(this.BtnMesajSil_Click);
            // 
            // BtnMesajGuncelle
            // 
            this.BtnMesajGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnMesajGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMesajGuncelle.ForeColor = System.Drawing.Color.Teal;
            this.BtnMesajGuncelle.Location = new System.Drawing.Point(192, 340);
            this.BtnMesajGuncelle.Name = "BtnMesajGuncelle";
            this.BtnMesajGuncelle.Size = new System.Drawing.Size(149, 64);
            this.BtnMesajGuncelle.TabIndex = 5;
            this.BtnMesajGuncelle.Text = "Güncelle";
            this.BtnMesajGuncelle.UseVisualStyleBackColor = false;
            this.BtnMesajGuncelle.Click += new System.EventHandler(this.BtnMesajGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.ForeColor = System.Drawing.Color.Teal;
            this.BtnKaydet.Location = new System.Drawing.Point(16, 340);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(149, 64);
            this.BtnKaydet.TabIndex = 4;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RTBMesaj
            // 
            this.RTBMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RTBMesaj.ForeColor = System.Drawing.Color.Blue;
            this.RTBMesaj.Location = new System.Drawing.Point(223, 87);
            this.RTBMesaj.Name = "RTBMesaj";
            this.RTBMesaj.Size = new System.Drawing.Size(402, 216);
            this.RTBMesaj.TabIndex = 3;
            this.RTBMesaj.Text = "";
            // 
            // listViewMesajlar
            // 
            this.listViewMesajlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listViewMesajlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MesajId,
            this.MusteriAdSoyad,
            this.MesajIcerik});
            this.listViewMesajlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewMesajlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listViewMesajlar.HideSelection = false;
            this.listViewMesajlar.Location = new System.Drawing.Point(21, 450);
            this.listViewMesajlar.Name = "listViewMesajlar";
            this.listViewMesajlar.Size = new System.Drawing.Size(744, 299);
            this.listViewMesajlar.TabIndex = 5;
            this.listViewMesajlar.UseCompatibleStateImageBehavior = false;
            this.listViewMesajlar.View = System.Windows.Forms.View.Details;
            this.listViewMesajlar.DoubleClick += new System.EventHandler(this.listViewMesajlar_DoubleClick);
            // 
            // MesajId
            // 
            this.MesajId.Text = "Mesaj Numarası";
            this.MesajId.Width = 189;
            // 
            // MusteriAdSoyad
            // 
            this.MusteriAdSoyad.Text = "Müşteri Ad - Soyad";
            this.MusteriAdSoyad.Width = 200;
            // 
            // MesajIcerik
            // 
            this.MesajIcerik.Text = "Mesaj İçerik";
            this.MesajIcerik.Width = 503;
            // 
            // BtnCikis5
            // 
            this.BtnCikis5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCikis5.BackgroundImage")));
            this.BtnCikis5.Location = new System.Drawing.Point(776, 15);
            this.BtnCikis5.Name = "BtnCikis5";
            this.BtnCikis5.Size = new System.Drawing.Size(55, 58);
            this.BtnCikis5.TabIndex = 6;
            this.BtnCikis5.UseVisualStyleBackColor = true;
            this.BtnCikis5.Click += new System.EventHandler(this.BtnCikis5_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(16, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 134);
            this.panel2.TabIndex = 8;
            // 
            // FormMesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(831, 749);
            this.Controls.Add(this.BtnCikis5);
            this.Controls.Add(this.listViewMesajlar);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMesajlar";
            this.Text = "FormMesajlar";
            this.Load += new System.EventHandler(this.FormMesajlar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.RichTextBox RTBMesaj;
        private System.Windows.Forms.ListView listViewMesajlar;
        private System.Windows.Forms.ColumnHeader MesajId;
        private System.Windows.Forms.ColumnHeader MusteriAdSoyad;
        private System.Windows.Forms.ColumnHeader MesajIcerik;
        private System.Windows.Forms.Button BtnAlanTemizle3;
        private System.Windows.Forms.Button BtnMesajSil;
        private System.Windows.Forms.Button BtnMesajGuncelle;
        private System.Windows.Forms.Button BtnCikis5;
        private System.Windows.Forms.Panel panel2;
    }
}