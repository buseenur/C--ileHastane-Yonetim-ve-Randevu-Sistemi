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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TblSekreter where SekreterTC=@P1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay fr = new FrmSekreterDetay();
                fr.tcnumara=MskTc.Text;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı şifre ya da TC girdiniz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close(); 
        }
    }
}
