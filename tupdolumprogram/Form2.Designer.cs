namespace tupdolumprogram
{
    partial class Form2
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTupId = new System.Windows.Forms.ComboBox();
            this.cmbGazId = new System.Windows.Forms.ComboBox();
            this.cmbPersonelId = new System.Windows.Forms.ComboBox();
            this.dtpDolumTarihi = new System.Windows.Forms.DateTimePicker();
            this.numDolumMiktariKg = new System.Windows.Forms.NumericUpDown();
            this.numDolumMiktariM3 = new System.Windows.Forms.NumericUpDown();
            this.numDolumBasinciBar = new System.Windows.Forms.NumericUpDown();
            this.numSicaklikC = new System.Windows.Forms.NumericUpDown();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDuzelt = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbDolumDurumu = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDolumMiktariKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDolumMiktariM3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDolumBasinciBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSicaklikC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tüp Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gaz Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dolum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dolum Miktarı (Kg)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Dolum Miktarı (m3)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Dolum Basıncı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Sıcaklık";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Dolum Durumu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Açıklama";
            // 
            // cmbTupId
            // 
            this.cmbTupId.FormattingEnabled = true;
            this.cmbTupId.Location = new System.Drawing.Point(136, 32);
            this.cmbTupId.Name = "cmbTupId";
            this.cmbTupId.Size = new System.Drawing.Size(138, 21);
            this.cmbTupId.TabIndex = 4;
            // 
            // cmbGazId
            // 
            this.cmbGazId.FormattingEnabled = true;
            this.cmbGazId.Location = new System.Drawing.Point(136, 63);
            this.cmbGazId.Name = "cmbGazId";
            this.cmbGazId.Size = new System.Drawing.Size(138, 21);
            this.cmbGazId.TabIndex = 5;
            // 
            // cmbPersonelId
            // 
            this.cmbPersonelId.FormattingEnabled = true;
            this.cmbPersonelId.Location = new System.Drawing.Point(136, 96);
            this.cmbPersonelId.Name = "cmbPersonelId";
            this.cmbPersonelId.Size = new System.Drawing.Size(138, 21);
            this.cmbPersonelId.TabIndex = 6;
            // 
            // dtpDolumTarihi
            // 
            this.dtpDolumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDolumTarihi.Location = new System.Drawing.Point(136, 128);
            this.dtpDolumTarihi.Name = "dtpDolumTarihi";
            this.dtpDolumTarihi.Size = new System.Drawing.Size(131, 20);
            this.dtpDolumTarihi.TabIndex = 7;
            // 
            // numDolumMiktariKg
            // 
            this.numDolumMiktariKg.Location = new System.Drawing.Point(136, 157);
            this.numDolumMiktariKg.Name = "numDolumMiktariKg";
            this.numDolumMiktariKg.Size = new System.Drawing.Size(120, 20);
            this.numDolumMiktariKg.TabIndex = 8;
            // 
            // numDolumMiktariM3
            // 
            this.numDolumMiktariM3.Location = new System.Drawing.Point(136, 184);
            this.numDolumMiktariM3.Name = "numDolumMiktariM3";
            this.numDolumMiktariM3.Size = new System.Drawing.Size(120, 20);
            this.numDolumMiktariM3.TabIndex = 9;
            // 
            // numDolumBasinciBar
            // 
            this.numDolumBasinciBar.Location = new System.Drawing.Point(136, 216);
            this.numDolumBasinciBar.Name = "numDolumBasinciBar";
            this.numDolumBasinciBar.Size = new System.Drawing.Size(120, 20);
            this.numDolumBasinciBar.TabIndex = 10;
            // 
            // numSicaklikC
            // 
            this.numSicaklikC.Location = new System.Drawing.Point(136, 247);
            this.numSicaklikC.Name = "numSicaklikC";
            this.numSicaklikC.Size = new System.Drawing.Size(120, 20);
            this.numSicaklikC.TabIndex = 11;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(136, 312);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(170, 82);
            this.txtAciklama.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 43;
            this.dataGridView1.Size = new System.Drawing.Size(465, 385);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(311, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.Location = new System.Drawing.Point(393, 3);
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(75, 23);
            this.btnDuzelt.TabIndex = 16;
            this.btnDuzelt.Text = "Düzelt";
            this.btnDuzelt.UseVisualStyleBackColor = true;
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(475, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Silme";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(557, 3);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 18;
            this.btnAra.Text = "Arama";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // cmbDolumDurumu
            // 
            this.cmbDolumDurumu.FormattingEnabled = true;
            this.cmbDolumDurumu.Items.AddRange(new object[] {
            "İptal",
            "Tamamlandı",
            "Devam Ediyor",
            "Beklemede"});
            this.cmbDolumDurumu.Location = new System.Drawing.Point(136, 275);
            this.cmbDolumDurumu.Name = "cmbDolumDurumu";
            this.cmbDolumDurumu.Size = new System.Drawing.Size(121, 21);
            this.cmbDolumDurumu.TabIndex = 19;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(136, 400);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 20);
            this.txtID.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cmbDolumDurumu);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzelt);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.numSicaklikC);
            this.Controls.Add(this.numDolumBasinciBar);
            this.Controls.Add(this.numDolumMiktariM3);
            this.Controls.Add(this.numDolumMiktariKg);
            this.Controls.Add(this.dtpDolumTarihi);
            this.Controls.Add(this.cmbPersonelId);
            this.Controls.Add(this.cmbGazId);
            this.Controls.Add(this.cmbTupId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDolumMiktariKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDolumMiktariM3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDolumBasinciBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSicaklikC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTupId;
        private System.Windows.Forms.ComboBox cmbGazId;
        private System.Windows.Forms.ComboBox cmbPersonelId;
        private System.Windows.Forms.DateTimePicker dtpDolumTarihi;
        private System.Windows.Forms.NumericUpDown numDolumMiktariKg;
        private System.Windows.Forms.NumericUpDown numDolumMiktariM3;
        private System.Windows.Forms.NumericUpDown numDolumBasinciBar;
        private System.Windows.Forms.NumericUpDown numSicaklikC;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzelt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbDolumDurumu;
        private System.Windows.Forms.TextBox txtID;
    }
}