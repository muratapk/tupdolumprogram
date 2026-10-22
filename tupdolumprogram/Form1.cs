using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tupdolumprogram
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MD7LI3L\\SQLEXPRESS;Initial Catalog=GazTupMuayeneDB;Integrated Security=True;TrustServerCertificate=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        void doldur()
        {
            string sorgu = "Select * from TupSahipleri";
            SqlCommand cmd2 = new SqlCommand(sorgu, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        void Temizle()
        {
            txtFirmaAdi.Clear();
            txtYetkiliKisi.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtAdres.Clear();
            txtVergiNo.Clear();
            cmbAktif.SelectedIndex = -1;
            dtpKayitTarihi.Value = DateTime.Now;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string cumle= "insert into TupSahipleri(FirmaAdi,YetkiliKisi,Telefon,Email,Adres,VergiNo,AktifMi,KayitTarihi) " +
                    "values (@firmaAdi, @yetkiliKisi, @telefon, @email, @adres, @vergiNo, @aktifMi, @kayitTarihi)";
                MessageBox.Show("Bağlantı Başarılı");
                SqlCommand cmd=new SqlCommand(cumle, conn);
                cmd.Parameters.AddWithValue("@firmaAdi", txtFirmaAdi.Text);
                cmd.Parameters.AddWithValue("@yetkiliKisi", txtYetkiliKisi.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
                cmd.Parameters.AddWithValue("@vergiNo", txtVergiNo.Text);
                cmd.Parameters.AddWithValue("@aktifMi", cmbAktif.SelectedItem);
                cmd.Parameters.AddWithValue("@kayitTarihi", dtpKayitTarihi.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı");
                Temizle();
                /*Data Grid Veri Doldurmak için Kullanılan Yapı*/
                doldur();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Hücreye Tıklandı");
            int satir=dataGridView1.SelectedCells[0].RowIndex;
            //seçilen hücreye ait satırın index numarasını aldık
            txtFirmaAdi.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            txtYetkiliKisi.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
            txtAdres.Text = dataGridView1.Rows[satir].Cells[5].Value.ToString();
            txtVergiNo.Text = dataGridView1.Rows[satir].Cells[6].Value.ToString();
            cmbAktif.SelectedItem = dataGridView1.Rows[satir].Cells[7].Value.ToString();
            dtpKayitTarihi.Value = Convert.ToDateTime(dataGridView1.Rows[satir].Cells[8].Value);
            txtId.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();

        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            conn.Open();
            string cumle = "update TupSahipleri set FirmaAdi=@firmaAdi, YetkiliKisi=@yetkiliKisi," +
                " Telefon=@telefon, Email=@email," +
                " Adres=@adres, VergiNo=@vergiNo, AktifMi=@aktifMi, KayitTarihi=@kayitTarihi where TupSahibiID=@id";
            SqlCommand cmd = new SqlCommand(cumle, conn);

            cmd.Parameters.AddWithValue("@firmaAdi", txtFirmaAdi.Text);
            cmd.Parameters.AddWithValue("@yetkiliKisi", txtYetkiliKisi.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
            cmd.Parameters.AddWithValue("@vergiNo", txtVergiNo.Text);
            cmd.Parameters.AddWithValue("@aktifMi", cmbAktif.SelectedItem);
            cmd.Parameters.AddWithValue("@kayitTarihi", dtpKayitTarihi.Value);
            cmd.Parameters.AddWithValue("@id", txtId.Text);

            cmd.ExecuteNonQuery();
            //sql komutunu çalıştırır ve veritabanında güncelleme yapar
            MessageBox.Show("Güncelleme Başarılı");
            Temizle();
            doldur();

            conn.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            DialogResult cevap = MessageBox.Show("Bu Kaydı Silmek İstiyor musunuz", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (cevap == DialogResult.Yes)
            {
                string cumle = "delete from TupSahipleri where TupSahibiID=@id";
                SqlCommand cmd = new SqlCommand(cumle, conn);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
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

        private void btnArama_Click(object sender, EventArgs e)
        {
            string cumle = "";
            if (radioFirma.Checked)
            {
                 cumle = "Select * from TupSahipleri where FirmaAdi like '%" + txtAramaYap.Text + "%'";
            }
            else if (radioYetkili.Checked)
            {
                 cumle = "Select * from TupSahipleri where YetkiliKisi like '%" + txtAramaYap.Text + "%'";
            }
            else
            {
                MessageBox.Show("Lütfen Arama Kriterini Seçiniz");
            }
            conn.Open();
            SqlCommand cmd = new SqlCommand(cumle, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();

        }
    }
}
