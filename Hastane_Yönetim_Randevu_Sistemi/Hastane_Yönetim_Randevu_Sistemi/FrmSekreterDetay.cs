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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string tcnumara;
        SqlBaglantisi bgl=new SqlBaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text= tcnumara;

            //Ad-Soyad Çekme
            SqlCommand komut = new SqlCommand("select SekreterAdSoyad from TblSekreter where SekreterTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları Datagride Aktarma
            DataTable dt=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TblBranslar",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource= dt;

            //Doktorları Datagride Çekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select (DoktorAd+' '+DoktorSoyad)as 'Doktorlar',DoktorBrans from TblDoktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView3.DataSource= dt1;

            //Branşları Comboboxa Aktarma
            SqlCommand komut1 = new SqlCommand("select BransAd from TblBranslar", bgl.baglanti());
            SqlDataReader dr1= komut1.ExecuteReader();
            while (dr1.Read())
            {
                CmbBranş.Items.Add(dr1[0].ToString());
            }
            bgl.baglanti().Close();


            
        }


        //Doktorları comboboxa çekme
        private void CmbBranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut2 = new SqlCommand("select DoktorAd,DoktorSoyad from TblDoktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", CmbBranş.Text);
            SqlDataReader dr3= komut2.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydt_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet=new SqlCommand("insert into TblRandevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@p1,@p2,@p3,@p4)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2",MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", CmbBranş.Text);
            komutkaydet.Parameters.AddWithValue("@p4", CmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnOluştr_Click(object sender, EventArgs e)
        {
            SqlCommand komutolustur = new SqlCommand("insert into TblDuyurular (Duyuru) values (@p1)", bgl.baglanti());
            komutolustur.Parameters.AddWithValue("@p1",RchDuyuru.Text);
            komutolustur.ExecuteNonQuery() ;
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDktrPneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr= new FrmDoktorPaneli();
            fr.Show();
        }

        private void BtnBrnşPnli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli fr=new FrmBransPaneli();
            fr.Show();
        }

        private void BtnRandvuLste_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr=new FrmRandevuListesi();
            fr.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
    }
    }

