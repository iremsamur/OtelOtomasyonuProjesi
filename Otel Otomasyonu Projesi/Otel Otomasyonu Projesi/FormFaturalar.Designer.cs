
namespace Otel_Otomasyonu_Projesi
{
    partial class FormFaturalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaturalar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnFaturaEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCikis6 = new System.Windows.Forms.Button();
            this.DTPFaturaTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFaturaTutar = new System.Windows.Forms.TextBox();
            this.TxtFaturaAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnFaturaGoster = new System.Windows.Forms.Button();
            this.BtnAlanlariTemizle2 = new System.Windows.Forms.Button();
            this.BtnFaturaSil = new System.Windows.Forms.Button();
            this.BtnFaturaGuncelle = new System.Windows.Forms.Button();
            this.DGVFaturalar = new System.Windows.Forms.DataGridView();
            this.FaturaIdNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaOdemeTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFaturalar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFaturaEkle
            // 
            this.BtnFaturaEkle.BackColor = System.Drawing.Color.White;
            this.BtnFaturaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFaturaEkle.ForeColor = System.Drawing.Color.Purple;
            this.BtnFaturaEkle.Image = ((System.Drawing.Image)(resources.GetObject("BtnFaturaEkle.Image")));
            this.BtnFaturaEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFaturaEkle.Location = new System.Drawing.Point(17, 21);
            this.BtnFaturaEkle.Name = "BtnFaturaEkle";
            this.BtnFaturaEkle.Size = new System.Drawing.Size(154, 86);
            this.BtnFaturaEkle.TabIndex = 1;
            this.BtnFaturaEkle.Text = "   Yeni Fatura Ekle";
            this.BtnFaturaEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFaturaEkle.UseVisualStyleBackColor = false;
            this.BtnFaturaEkle.Click += new System.EventHandler(this.BtnFaturaEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura Adı : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.BtnCikis6);
            this.panel1.Controls.Add(this.DTPFaturaTarih);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtFaturaTutar);
            this.panel1.Controls.Add(this.TxtFaturaAdi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(478, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 171);
            this.panel1.TabIndex = 2;
            // 
            // BtnCikis6
            // 
            this.BtnCikis6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCikis6.BackgroundImage")));
            this.BtnCikis6.Location = new System.Drawing.Point(481, 3);
            this.BtnCikis6.Name = "BtnCikis6";
            this.BtnCikis6.Size = new System.Drawing.Size(52, 51);
            this.BtnCikis6.TabIndex = 6;
            this.BtnCikis6.UseVisualStyleBackColor = true;
            this.BtnCikis6.Click += new System.EventHandler(this.BtnCikis6_Click);
            // 
            // DTPFaturaTarih
            // 
            this.DTPFaturaTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTPFaturaTarih.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DTPFaturaTarih.Location = new System.Drawing.Point(267, 127);
            this.DTPFaturaTarih.Name = "DTPFaturaTarih";
            this.DTPFaturaTarih.Size = new System.Drawing.Size(200, 20);
            this.DTPFaturaTarih.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fatura Ödeme Tarihi : ";
            // 
            // TxtFaturaTutar
            // 
            this.TxtFaturaTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFaturaTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TxtFaturaTutar.Location = new System.Drawing.Point(268, 75);
            this.TxtFaturaTutar.Name = "TxtFaturaTutar";
            this.TxtFaturaTutar.Size = new System.Drawing.Size(126, 29);
            this.TxtFaturaTutar.TabIndex = 3;
            // 
            // TxtFaturaAdi
            // 
            this.TxtFaturaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFaturaAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TxtFaturaAdi.Location = new System.Drawing.Point(268, 25);
            this.TxtFaturaAdi.Name = "TxtFaturaAdi";
            this.TxtFaturaAdi.Size = new System.Drawing.Size(126, 29);
            this.TxtFaturaAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fatura Tutarı : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.BtnFaturaGoster);
            this.panel2.Controls.Add(this.BtnAlanlariTemizle2);
            this.panel2.Controls.Add(this.BtnFaturaSil);
            this.panel2.Controls.Add(this.BtnFaturaGuncelle);
            this.panel2.Controls.Add(this.BtnFaturaEkle);
            this.panel2.Location = new System.Drawing.Point(478, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 233);
            this.panel2.TabIndex = 3;
            // 
            // BtnFaturaGoster
            // 
            this.BtnFaturaGoster.BackColor = System.Drawing.Color.White;
            this.BtnFaturaGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFaturaGoster.ForeColor = System.Drawing.Color.Purple;
            this.BtnFaturaGoster.Image = ((System.Drawing.Image)(resources.GetObject("BtnFaturaGoster.Image")));
            this.BtnFaturaGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFaturaGoster.Location = new System.Drawing.Point(186, 124);
            this.BtnFaturaGoster.Name = "BtnFaturaGoster";
            this.BtnFaturaGoster.Size = new System.Drawing.Size(208, 87);
            this.BtnFaturaGoster.TabIndex = 5;
            this.BtnFaturaGoster.Text = "Fatura Bilgileri Göster";
            this.BtnFaturaGoster.UseVisualStyleBackColor = false;
            this.BtnFaturaGoster.Click += new System.EventHandler(this.BtnFaturaGoster_Click);
            // 
            // BtnAlanlariTemizle2
            // 
            this.BtnAlanlariTemizle2.BackColor = System.Drawing.Color.White;
            this.BtnAlanlariTemizle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAlanlariTemizle2.ForeColor = System.Drawing.Color.Purple;
            this.BtnAlanlariTemizle2.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlanlariTemizle2.Image")));
            this.BtnAlanlariTemizle2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlanlariTemizle2.Location = new System.Drawing.Point(356, 21);
            this.BtnAlanlariTemizle2.Name = "BtnAlanlariTemizle2";
            this.BtnAlanlariTemizle2.Size = new System.Drawing.Size(180, 89);
            this.BtnAlanlariTemizle2.TabIndex = 4;
            this.BtnAlanlariTemizle2.Text = "Alanları Temizle";
            this.BtnAlanlariTemizle2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAlanlariTemizle2.UseVisualStyleBackColor = false;
            this.BtnAlanlariTemizle2.Click += new System.EventHandler(this.BtnAlanlariTemizle2_Click);
            // 
            // BtnFaturaSil
            // 
            this.BtnFaturaSil.BackColor = System.Drawing.Color.White;
            this.BtnFaturaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFaturaSil.ForeColor = System.Drawing.Color.Purple;
            this.BtnFaturaSil.Image = ((System.Drawing.Image)(resources.GetObject("BtnFaturaSil.Image")));
            this.BtnFaturaSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFaturaSil.Location = new System.Drawing.Point(17, 124);
            this.BtnFaturaSil.Name = "BtnFaturaSil";
            this.BtnFaturaSil.Size = new System.Drawing.Size(156, 87);
            this.BtnFaturaSil.TabIndex = 3;
            this.BtnFaturaSil.Text = "Fatura Bilgi Sil";
            this.BtnFaturaSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFaturaSil.UseVisualStyleBackColor = false;
            this.BtnFaturaSil.Click += new System.EventHandler(this.BtnFaturaSil_Click);
            // 
            // BtnFaturaGuncelle
            // 
            this.BtnFaturaGuncelle.BackColor = System.Drawing.Color.White;
            this.BtnFaturaGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFaturaGuncelle.ForeColor = System.Drawing.Color.Purple;
            this.BtnFaturaGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("BtnFaturaGuncelle.Image")));
            this.BtnFaturaGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFaturaGuncelle.Location = new System.Drawing.Point(186, 21);
            this.BtnFaturaGuncelle.Name = "BtnFaturaGuncelle";
            this.BtnFaturaGuncelle.Size = new System.Drawing.Size(161, 86);
            this.BtnFaturaGuncelle.TabIndex = 2;
            this.BtnFaturaGuncelle.Text = "Fatura Bilgi Güncelle";
            this.BtnFaturaGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFaturaGuncelle.UseVisualStyleBackColor = false;
            this.BtnFaturaGuncelle.Click += new System.EventHandler(this.BtnFaturaGuncelle_Click);
            // 
            // DGVFaturalar
            // 
            this.DGVFaturalar.AllowUserToAddRows = false;
            this.DGVFaturalar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            this.DGVFaturalar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVFaturalar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFaturalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVFaturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFaturalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FaturaIdNo,
            this.FaturaAdi,
            this.FaturaTutar,
            this.FaturaOdemeTarih});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVFaturalar.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVFaturalar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DGVFaturalar.Location = new System.Drawing.Point(1, 0);
            this.DGVFaturalar.Name = "DGVFaturalar";
            this.DGVFaturalar.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFaturalar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Purple;
            this.DGVFaturalar.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVFaturalar.Size = new System.Drawing.Size(452, 410);
            this.DGVFaturalar.TabIndex = 0;
            this.DGVFaturalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFaturalar_CellClick);
            // 
            // FaturaIdNo
            // 
            this.FaturaIdNo.DataPropertyName = "FaturaIdNo";
            this.FaturaIdNo.HeaderText = "Fatura Sıra No";
            this.FaturaIdNo.Name = "FaturaIdNo";
            this.FaturaIdNo.ReadOnly = true;
            // 
            // FaturaAdi
            // 
            this.FaturaAdi.DataPropertyName = "FaturaAdi";
            this.FaturaAdi.HeaderText = "Fatura Adı";
            this.FaturaAdi.Name = "FaturaAdi";
            this.FaturaAdi.ReadOnly = true;
            // 
            // FaturaTutar
            // 
            this.FaturaTutar.DataPropertyName = "FaturaTutar";
            this.FaturaTutar.HeaderText = "Fatura Tutarı";
            this.FaturaTutar.Name = "FaturaTutar";
            this.FaturaTutar.ReadOnly = true;
            // 
            // FaturaOdemeTarih
            // 
            this.FaturaOdemeTarih.DataPropertyName = "FaturaOdemeTarih";
            this.FaturaOdemeTarih.HeaderText = "Fatura Ödeme Tarihi";
            this.FaturaOdemeTarih.Name = "FaturaOdemeTarih";
            this.FaturaOdemeTarih.ReadOnly = true;
            // 
            // FormFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1042, 412);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGVFaturalar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFaturalar";
            this.Text = "Faturalar";
            this.Load += new System.EventHandler(this.FormFaturalar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFaturalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnFaturaEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtFaturaTutar;
        private System.Windows.Forms.TextBox TxtFaturaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnAlanlariTemizle2;
        private System.Windows.Forms.Button BtnFaturaSil;
        private System.Windows.Forms.Button BtnFaturaGuncelle;
        private System.Windows.Forms.DateTimePicker DTPFaturaTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFaturaGoster;
        private System.Windows.Forms.Button BtnCikis6;
        private System.Windows.Forms.DataGridView DGVFaturalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaIdNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaOdemeTarih;
    }
}