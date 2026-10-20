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
            MessageBox.Show("Hücreye Tıklandı");    
        }
    }
}
