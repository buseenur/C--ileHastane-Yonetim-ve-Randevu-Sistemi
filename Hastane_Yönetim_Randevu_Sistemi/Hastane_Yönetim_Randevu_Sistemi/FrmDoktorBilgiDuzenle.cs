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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();
        public string tcno;
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTc.Text = tcno;

            SqlCommand komut = new SqlCommand("select*from TblDoktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MskTc.Text);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text= dr[2].ToString();
                CmbBranş.Text= dr[3].ToString();
                TxtSifre.Text= dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnBilgiGnclle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgnclle = new SqlCommand("update TblDoktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komutgnclle.Parameters.AddWithValue("@p1", TxtAd.Text);
            komutgnclle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komutgnclle.Parameters.AddWithValue("@p3", CmbBranş.Text);
            komutgnclle.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komutgnclle.Parameters.AddWithValue("@p5", MskTc.Text);
            komutgnclle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
