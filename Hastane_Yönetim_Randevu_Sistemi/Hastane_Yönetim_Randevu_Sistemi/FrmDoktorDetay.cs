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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();
        public string tc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
             LblTc.Text = tc;

            //Doktor Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from TblDoktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTc.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Listesi Getirme
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select * from TblRandevular where RandevuDoktor='"+LblAdSoyad.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnBlgDznle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr=new FrmDoktorBilgiDuzenle();
            fr.tcno = LblTc.Text;
            fr.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr=new FrmDuyurular();
            fr.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
