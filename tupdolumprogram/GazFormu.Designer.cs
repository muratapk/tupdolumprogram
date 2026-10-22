namespace tupdolumprogram
{
    partial class GazFormu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGazAdi = new System.Windows.Forms.TextBox();
            this.txtGazKodu = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDuzelt = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnArama = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkAktifMi = new System.Windows.Forms.CheckBox();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gazın Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gazın Kodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Aktif Mi:";
            // 
            // txtGazAdi
            // 
            this.txtGazAdi.Location = new System.Drawing.Point(150, 57);
            this.txtGazAdi.Name = "txtGazAdi";
            this.txtGazAdi.Size = new System.Drawing.Size(221, 23);
            this.txtGazAdi.TabIndex = 2;
            // 
            // txtGazKodu
            // 
            this.txtGazKodu.Location = new System.Drawing.Point(150, 101);
            this.txtGazKodu.Name = "txtGazKodu";
            this.txtGazKodu.Size = new System.Drawing.Size(221, 23);
            this.txtGazKodu.TabIndex = 3;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(150, 146);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(221, 45);
            this.txtAciklama.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(43, 9);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 36);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.Location = new System.Drawing.Point(125, 9);
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(75, 36);
            this.btnDuzelt.TabIndex = 6;
            this.btnDuzelt.Text = "Düzelt";
            this.btnDuzelt.UseVisualStyleBackColor = true;
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(206, 9);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 36);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Silme";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnArama
            // 
            this.btnArama.Location = new System.Drawing.Point(287, 9);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(75, 36);
            this.btnArama.TabIndex = 8;
            this.btnArama.Text = "Arama";
            this.btnArama.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 43;
            this.dataGridView1.Size = new System.Drawing.Size(659, 389);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // chkAktifMi
            // 
            this.chkAktifMi.AutoSize = true;
            this.chkAktifMi.Location = new System.Drawing.Point(150, 208);
            this.chkAktifMi.Name = "chkAktifMi";
            this.chkAktifMi.Size = new System.Drawing.Size(55, 22);
            this.chkAktifMi.TabIndex = 10;
            this.chkAktifMi.Text = "Aktif";
            this.chkAktifMi.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 258);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(173, 23);
            this.txtId.TabIndex = 11;
            // 
            // GazFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.chkAktifMi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzelt);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtGazKodu);
            this.Controls.Add(this.txtGazAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GazFormu";
            this.Text = "GazFormu";
            this.Load += new System.EventHandler(this.GazFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGazAdi;
        private System.Windows.Forms.TextBox txtGazKodu;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzelt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkAktifMi;
        private System.Windows.Forms.TextBox txtId;
    }
}