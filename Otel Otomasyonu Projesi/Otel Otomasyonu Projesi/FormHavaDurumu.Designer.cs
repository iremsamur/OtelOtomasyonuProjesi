
namespace Otel_Otomasyonu_Projesi
{
    partial class FormHavaDurumu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHavaDurumu));
            this.DGVHavaDurum = new System.Windows.Forms.DataGridView();
            this.ilAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.havaDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxSicaklik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCikis21 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHavaDurum)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVHavaDurum
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Purple;
            this.DGVHavaDurum.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVHavaDurum.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVHavaDurum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVHavaDurum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHavaDurum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ilAdi,
            this.havaDurum,
            this.MaxSicaklik});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVHavaDurum.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVHavaDurum.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DGVHavaDurum.Location = new System.Drawing.Point(2, 48);
            this.DGVHavaDurum.Name = "DGVHavaDurum";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVHavaDurum.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Purple;
            this.DGVHavaDurum.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVHavaDurum.Size = new System.Drawing.Size(344, 390);
            this.DGVHavaDurum.TabIndex = 0;
            this.DGVHavaDurum.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVHavaDurum_CellFormatting);
            // 
            // ilAdi
            // 
            this.ilAdi.DataPropertyName = "ilAdi";
            this.ilAdi.HeaderText = "İL";
            this.ilAdi.Name = "ilAdi";
            // 
            // havaDurum
            // 
            this.havaDurum.HeaderText = "HAVA DURUMU";
            this.havaDurum.Name = "havaDurum";
            // 
            // MaxSicaklik
            // 
            this.MaxSicaklik.HeaderText = "Maximum Sıcaklık";
            this.MaxSicaklik.Name = "MaxSicaklik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(31, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hava Durumu Bilgileri";
            // 
            // BtnCikis21
            // 
            this.BtnCikis21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCikis21.BackgroundImage")));
            this.BtnCikis21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis21.Location = new System.Drawing.Point(352, 9);
            this.BtnCikis21.Name = "BtnCikis21";
            this.BtnCikis21.Size = new System.Drawing.Size(55, 55);
            this.BtnCikis21.TabIndex = 5;
            this.BtnCikis21.UseVisualStyleBackColor = true;
            this.BtnCikis21.Click += new System.EventHandler(this.BtnCikis21_Click);
            // 
            // FormHavaDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.BtnCikis21);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVHavaDurum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHavaDurumu";
            this.Text = "Hava Durumu";
            this.Load += new System.EventHandler(this.FormHavaDurumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVHavaDurum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVHavaDurum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn havaDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxSicaklik;
        private System.Windows.Forms.Button BtnCikis21;
    }
}