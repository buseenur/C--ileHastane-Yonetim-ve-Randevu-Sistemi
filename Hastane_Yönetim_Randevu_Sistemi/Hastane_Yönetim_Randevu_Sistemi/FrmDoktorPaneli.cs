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
using System.Data.Common;

namespace Hastane_Yönetim_Randevu_Sistemi
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select BransAd from TblBranslar", bgl.baglanti());
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                CmbBrans.Items.Add(dr[0]).ToString();
            }
            bgl.baglanti().Close();

           DataTable dt=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from TblDoktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into TblDoktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1", TxtAd.Text);
            komutekle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komutekle.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komutekle.Parameters.AddWithValue("@p4", MskTC.Text);
            komutekle.Parameters.AddWithValue("@p5", TxtSifre.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();  
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from TblDoktorlar where DoktorTC=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", MskTC.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void BtnGncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgnclle = new SqlCommand("update TblDoktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTC=@p4", bgl.baglanti());
            komutgnclle.Parameters.AddWithValue("@p1", TxtAd.Text);
            komutgnclle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komutgnclle.Parameters.AddWithValue("@p3",CmbBrans.Text);
            komutgnclle.Parameters.AddWithValue("@p4",MskTC.Text);
            komutgnclle.Parameters.AddWithValue("@p5", TxtSifre.Text);
            komutgnclle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
