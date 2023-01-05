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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("select * from TblDoktorlar where DoktorTC=@p1 and DoktorSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.tc = MskTc.Text;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı TC ya da şifre girdiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
            
        }
    }
}
