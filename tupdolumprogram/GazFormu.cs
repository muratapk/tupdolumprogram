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
    public partial class GazFormu : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MD7LI3L\\SQLEXPRESS;Initial Catalog=GazTupMuayeneDB;Integrated Security=True;TrustServerCertificate=True");
        public GazFormu()
        {
            InitializeComponent();
        }

        private void GazFormu_Load(object sender, EventArgs e)
        {
            doldur();
        }

        void doldur()
        {
            string sorgu = "Select * from Gazlar";
            SqlCommand cmd2 = new SqlCommand(sorgu, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string cumle= "insert into gazlar(GazAdi,GazKodu,Aciklama,AktifMi) " +
                    "values(@GazAdi,@GazKodu,@Aciklama,@AktifMi)";
                
                SqlCommand cmd = new SqlCommand(cumle, conn);
                cmd.Parameters.AddWithValue("@GazAdi", txtGazAdi.Text);
                cmd.Parameters.AddWithValue("@GazKodu", txtGazKodu.Text);
                cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                cmd.Parameters.AddWithValue("@AktifMi", chkAktifMi.Checked);

                cmd.ExecuteNonQuery();
                doldur();
                MessageBox.Show("Kayıt Başarılı");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = dataGridView1.SelectedCells[0].RowIndex;
            txtGazAdi.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            txtGazKodu.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            txtAciklama.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            chkAktifMi.Checked = bool.Parse(dataGridView1.Rows[satir].Cells[4].Value.ToString());
            txtId.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            DialogResult cevap = MessageBox.Show("Bu Kaydı Silmek İstiyor musunuz", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (cevap == DialogResult.Yes)
            {
                string cumle = "delete from Gazlar where GazID=@id";
                SqlCommand cmd = new SqlCommand(cumle, conn);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silme Başarılı");
               
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
            conn.Open();
            string cumle = "update Gazlar set GazAdi=@gazAdi, GazKodu=@gazKodu, " +
                "Aciklama=@aciklama, AktifMi=@aktifMi where GazID=@id";
            SqlCommand cmd = new SqlCommand(cumle, conn);
            cmd.Parameters.AddWithValue("@gazAdi", txtGazAdi.Text);
            cmd.Parameters.AddWithValue("@gazKodu", txtGazKodu.Text);
            cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@aktifMi", chkAktifMi.Checked);
            cmd.Parameters.AddWithValue("@id", txtId.Text);

            cmd.ExecuteNonQuery();
            //sql komutunu çalıştırır ve veritabanında güncelleme yapar
            MessageBox.Show("Güncelleme Başarılı");
            
            doldur();
        }
    }
}
