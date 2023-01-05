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

namespace Hastane_Yönetim_Randevu_Sistemi
{
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TblBranslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtBransId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into TblBranslar (BransAd) values(@p1)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1",TxtBransAd.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil=new SqlCommand("delete from TblBranslar where Bransid=@p1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1",TxtBransId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnGncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgnclle = new SqlCommand("update TblBranslar set BransAd=@p2 where Bransid=@p1", bgl.baglanti());
            komutgnclle.Parameters.AddWithValue("@p2", TxtBransAd.Text);
            komutgnclle.Parameters.AddWithValue("@p1", TxtBransId.Text);
            komutgnclle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
