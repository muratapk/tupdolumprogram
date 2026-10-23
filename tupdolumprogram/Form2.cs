using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tupdolumprogram
{
    
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MD7LI3L\\SQLEXPRESS;Initial Catalog=GazTupMuayeneDB;Integrated Security=True;TrustServerCertificate=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tupdoldur();
            Gazdoldur();
            Personedoldur();
            doldur();
        }
        void tupdoldur()
        {
            string sorgu = "Select * from Tupler";
            SqlCommand cmd2 = new SqlCommand(sorgu, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbTupId.DataSource = ds.Tables[0];
            cmbTupId.DisplayMember = "SeriNo";
            //veritabanındaki kolon adını yazıyoruz. Bu kolonun verileri combobox'ta görünecek
            cmbTupId.ValueMember = "TupId";
        }
        void doldur()
        {
            string sorgu = "Select Dolumlar.DolumID,Tupler.TupID,Gazlar.GazID,Personeller.PersonelID,Gazlar.GazAdi, Personeller.Ad, Personeller.Soyad, Tupler.SeriNo,Dolumlar.DolumTarihi,Dolumlar.DolumMiktariKg,Dolumlar.DolumMiktariM3,Dolumlar.DolumBasinciBar,Dolumlar.SicaklikC,Dolumlar.DolumDurumu,Dolumlar.Aciklama from Dolumlar inner join Gazlar " +
                "on Dolumlar.GazID = Gazlar.GazID inner join Personeller " +
                "on Dolumlar.PersonelID = Personeller.PersonelID inner join Tupler " +
                "on Dolumlar.TupID = Tupler.TupID";
            SqlCommand cmd2 = new SqlCommand(sorgu, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void Gazdoldur()
        {
            string sorgu = "Select * from Gazlar";
            SqlCommand cmd2 = new SqlCommand(sorgu, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbGazId.DataSource = ds.Tables[0];
            cmbGazId.DisplayMember = "GazAdi";
            //veritabanındaki kolon adını yazıyoruz. Bu kolonun verileri combobox'ta görünecek
            cmbGazId.ValueMember = "GazId";
        }
        void Personedoldur()
        {
            string sorgu = "Select PersonelID, Concat(Ad, ' ', Soyad) as AdSoyad from Personeller";
            SqlCommand cmd2 = new SqlCommand(sorgu, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbPersonelId.DataSource = ds.Tables[0];
            cmbPersonelId.DisplayMember = "AdSoyad";
            //veritabanındaki kolon adını yazıyoruz. Bu kolonun verileri combobox'ta görünecek
            cmbPersonelId.ValueMember = "PersonelID";
        }
        void Temizle()
        {
            cmbTupId.SelectedIndex = -1;
            cmbGazId.SelectedIndex = -1;
            cmbPersonelId.SelectedIndex = -1;
            dtpDolumTarihi.Value = DateTime.Now;
            numDolumMiktariKg.Value = 0;
            numDolumMiktariM3.Value = 0;
            numDolumBasinciBar.Value = 0;
            numSicaklikC.Value = 0;
            cmbDolumDurumu.SelectedIndex = -1;
            txtAciklama.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
            string cumle="insert into Dolumlar (TupID,GazID,PersonelID,DolumTarihi,DolumMiktariKg,DolumMiktariM3,DolumBasinciBar,SicaklikC,DolumDurumu,Aciklama)" +
                       "values (@TupID,@GazID,@PersonelID,@DolumTarihi,@DolumMiktariKg,@DolumMiktariM3,@DolumBasinciBar,@SicaklikC,@DolumDurumu,@Aciklama)";
             SqlCommand cmd=new SqlCommand(cumle, conn);
             cmd.Parameters.AddWithValue("@TupID", cmbTupId.SelectedValue);
             cmd.Parameters.AddWithValue("@GazID", cmbGazId.SelectedValue);
             cmd.Parameters.AddWithValue("@PersonelID", cmbPersonelId.SelectedValue);
             cmd.Parameters.AddWithValue("@DolumTarihi", dtpDolumTarihi.Value);
             cmd.Parameters.AddWithValue("@DolumMiktariKg", numDolumMiktariKg.Value);
             cmd.Parameters.AddWithValue("@DolumMiktariM3", numDolumMiktariM3.Value);
             cmd.Parameters.AddWithValue("@DolumBasinciBar", numDolumBasinciBar.Value);
             cmd.Parameters.AddWithValue("@SicaklikC", numSicaklikC.Value);
             cmd.Parameters.AddWithValue("@DolumDurumu", cmbDolumDurumu.Text);
             cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
             cmd.ExecuteNonQuery();
             MessageBox.Show("Kayıt Başarılı");
                Temizle();
                doldur();
                conn.Close(); 
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = dataGridView1.SelectedCells[0].RowIndex;
            cmbTupId.SelectedValue = dataGridView1.Rows[satir].Cells[1].Value;  
            cmbGazId.SelectedValue = dataGridView1.Rows[satir].Cells[2].Value;
            cmbPersonelId.SelectedValue = dataGridView1.Rows[satir].Cells[3].Value;
            dtpDolumTarihi.Value = Convert.ToDateTime(dataGridView1.Rows[satir].Cells[8].Value);
            numDolumMiktariKg.Value = Convert.ToDecimal(dataGridView1.Rows[satir].Cells[9].Value);
            numDolumMiktariM3.Value = Convert.ToDecimal(dataGridView1.Rows[satir].Cells[10].Value);
            numDolumBasinciBar.Value = Convert.ToDecimal(dataGridView1.Rows[satir].Cells[11].Value);
            numSicaklikC.Value = Convert.ToDecimal(dataGridView1.Rows[satir].Cells[12].Value);
            cmbDolumDurumu.Text = dataGridView1.Rows[satir].Cells[13].Value.ToString();
            txtAciklama.Text = dataGridView1.Rows[satir].Cells[14].Value.ToString();
            txtID.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            DialogResult cevap = MessageBox.Show("Bu Kaydı Silmek İstiyor musunuz", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (cevap == DialogResult.Yes)
            {
                string cumle = "delete from Dolumlar where DolumID=@id";
                SqlCommand cmd = new SqlCommand(cumle, conn);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silme Başarılı");
                Temizle();
                doldur();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }

            conn.Close();
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string cumle = "Update Dolumlar set TupID=@TupID,GazID=@GazID,PersonelID=@PersonelID," +
                            "DolumTarihi=@DolumTarihi,DolumMiktariKg=@DolumMiktariKg,DolumMiktariM3=@DolumMiktariM3," +
                            "DolumBasinciBar=@DolumBasinciBar,SicaklikC=@SicaklikC,DolumDurumu=@DolumDurumu,Aciklama=@Aciklama " +
                            "Where DolumId=@ID";
                SqlCommand cmd = new SqlCommand(cumle, conn);
                cmd.Parameters.AddWithValue("@TupID", cmbTupId.SelectedValue);
                cmd.Parameters.AddWithValue("@GazID", cmbGazId.SelectedValue);
                cmd.Parameters.AddWithValue("@PersonelID", cmbPersonelId.SelectedValue);
                cmd.Parameters.AddWithValue("@DolumTarihi", dtpDolumTarihi.Value);
                cmd.Parameters.AddWithValue("@DolumMiktariKg", numDolumMiktariKg.Value);
                cmd.Parameters.AddWithValue("@DolumMiktariM3", numDolumMiktariM3.Value);
                cmd.Parameters.AddWithValue("@DolumBasinciBar", numDolumBasinciBar.Value);
                cmd.Parameters.AddWithValue("@SicaklikC", numSicaklikC.Value);
                cmd.Parameters.AddWithValue("@DolumDurumu", cmbDolumDurumu.Text);
                cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Düzelt Başarılı");
                doldur();
                Temizle();
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }
    }
}
