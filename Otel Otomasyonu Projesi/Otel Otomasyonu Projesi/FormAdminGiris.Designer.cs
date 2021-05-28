
namespace Otel_Otomasyonu_Projesi
{
    partial class FormAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TxtParola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSifreUnutma = new System.Windows.Forms.Button();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCikis4 = new System.Windows.Forms.Button();
            this.BtnKullaniciAdiUnuttum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(346, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(346, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola : ";
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(628, 153);
            this.TxtKullaniciAdi.MaxLength = 500;
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(194, 35);
            this.TxtKullaniciAdi.TabIndex = 2;
            // 
            // TxtParola
            // 
            this.TxtParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtParola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TxtParola.Location = new System.Drawing.Point(628, 262);
            this.TxtParola.MaxLength = 500;
            this.TxtParola.Name = "TxtParola";
            this.TxtParola.PasswordChar = '*';
            this.TxtParola.Size = new System.Drawing.Size(194, 35);
            this.TxtParola.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(353, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(550, 53);
            this.label3.TabIndex = 7;
            this.label3.Text = "Diamond Hotel \'e Hoşgeldiniz ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSifreUnutma
            // 
            this.BtnSifreUnutma.BackColor = System.Drawing.Color.Yellow;
            this.BtnSifreUnutma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnSifreUnutma.Image = ((System.Drawing.Image)(resources.GetObject("BtnSifreUnutma.Image")));
            this.BtnSifreUnutma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSifreUnutma.Location = new System.Drawing.Point(114, 383);
            this.BtnSifreUnutma.Name = "BtnSifreUnutma";
            this.BtnSifreUnutma.Size = new System.Drawing.Size(255, 75);
            this.BtnSifreUnutma.TabIndex = 8;
            this.BtnSifreUnutma.Text = "Şifremi Unuttum";
            this.BtnSifreUnutma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSifreUnutma.UseVisualStyleBackColor = false;
            this.BtnSifreUnutma.Click += new System.EventHandler(this.BtnSifreUnutma_Click);
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.Color.Yellow;
            this.BtnGirisYap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnGirisYap.Image = ((System.Drawing.Image)(resources.GetObject("BtnGirisYap.Image")));
            this.BtnGirisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGirisYap.Location = new System.Drawing.Point(668, 383);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(255, 75);
            this.BtnGirisYap.TabIndex = 9;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackColor = System.Drawing.Color.Yellow;
            this.BtnTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.Image")));
            this.BtnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTemizle.Location = new System.Drawing.Point(945, 383);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(255, 75);
            this.BtnTemizle.TabIndex = 10;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = false;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 82);
            this.panel1.TabIndex = 11;
            // 
            // BtnCikis4
            // 
            this.BtnCikis4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCikis4.BackgroundImage")));
            this.BtnCikis4.Location = new System.Drawing.Point(1214, 22);
            this.BtnCikis4.Name = "BtnCikis4";
            this.BtnCikis4.Size = new System.Drawing.Size(53, 50);
            this.BtnCikis4.TabIndex = 12;
            this.BtnCikis4.UseVisualStyleBackColor = true;
            this.BtnCikis4.Click += new System.EventHandler(this.BtnCikis4_Click);
            // 
            // BtnKullaniciAdiUnuttum
            // 
            this.BtnKullaniciAdiUnuttum.BackColor = System.Drawing.Color.Yellow;
            this.BtnKullaniciAdiUnuttum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnKullaniciAdiUnuttum.Image = ((System.Drawing.Image)(resources.GetObject("BtnKullaniciAdiUnuttum.Image")));
            this.BtnKullaniciAdiUnuttum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKullaniciAdiUnuttum.Location = new System.Drawing.Point(388, 383);
            this.BtnKullaniciAdiUnuttum.Name = "BtnKullaniciAdiUnuttum";
            this.BtnKullaniciAdiUnuttum.Size = new System.Drawing.Size(255, 75);
            this.BtnKullaniciAdiUnuttum.TabIndex = 13;
            this.BtnKullaniciAdiUnuttum.Text = "Kullanıcı Adımı Unuttum";
            this.BtnKullaniciAdiUnuttum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnKullaniciAdiUnuttum.UseVisualStyleBackColor = false;
            this.BtnKullaniciAdiUnuttum.Click += new System.EventHandler(this.BtnKullaniciAdiUnuttum_Click);
            // 
            // FormAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1340, 749);
            this.Controls.Add(this.BtnKullaniciAdiUnuttum);
            this.Controls.Add(this.BtnCikis4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.BtnSifreUnutma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtParola);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormAdminGiris";
            this.Text = "Kullanıcı Giriş Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.TextBox TxtParola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSifreUnutma;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCikis4;
        private System.Windows.Forms.Button BtnKullaniciAdiUnuttum;
    }
}

